using AutoMapper;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public class OkolinaService : BaseService<OkolinaModel, OkolinaSearchRequest, OkolinaInsertRequest, Okolina>
    {
        public OkolinaService(Online_BookingContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<OkolinaModel> Get(OkolinaSearchRequest search)
        {
            var query = (from okolina in _context.Okolina
                         join okolinasmjestaj in _context.OkolinaSmjestaj.Where(x => x.SmjestajId == search.SmjestajId)
                         on okolina.OkolinaId equals okolinasmjestaj.OkolinaId
                         select new OkolinaModel()
                         {
                             OkolinaId = okolina.OkolinaId,
                             Naziv = okolina.Naziv,
                             OkolinaSmjestajId = okolinasmjestaj.OkolinaSmjestajId
                         }).ToList();

            return query;
        }
        public override OkolinaInsertRequest Insert(OkolinaInsertRequest model)
        {
            Okolina o = _mapper.Map<Okolina>(model);
            _context.Okolina.Add(o);
            _context.SaveChanges();
            OkolinaSmjestaj os = new OkolinaSmjestaj()
            {
                SmjestajId = model.SmjestajId,
                OkolinaId = o.OkolinaId
            };

            _context.OkolinaSmjestaj.Add(os);
            _context.SaveChanges();
            return model;
        }
    }
}
