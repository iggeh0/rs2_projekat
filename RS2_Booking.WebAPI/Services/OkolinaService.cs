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
    public class OkolinaService : IOkolinaService
    {
        private readonly Online_BookingContext _context;
        private readonly IMapper _mapper;

        public OkolinaService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<OkolinaModel> Get(OkolinaSearchRequest search)
        {
            if (search.GradId > 0)
            {
                var query = (from okolina in _context.Okolina
                             join okolinasmjestaj in _context.OkolinaSmjestaj.Where(x => x.SmjestajId != search.SmjestajId)
                             on okolina.OkolinaId equals okolinasmjestaj.OkolinaId
                             join smjestaj in _context.Smjestaj
                             on okolinasmjestaj.SmjestajId equals smjestaj.SmjestajId
                             join grad in _context.Grad
                               on smjestaj.GradId equals grad.GradId
                             where smjestaj.GradId == search.GradId
                             select new OkolinaModel()
                             {
                                 OkolinaId = okolina.OkolinaId,
                                 Naziv = okolina.Naziv,
                                 OkolinaSmjestajId = okolinasmjestaj.OkolinaSmjestajId,
                                 GradId = grad.GradId,
                                 SmjestajId = smjestaj.SmjestajId,
                                 Udaljenost = okolinasmjestaj.Udaljenost
                             }).ToList();


                if (query.Any())
                {

                    return query;
                }
                else
                    return null;
            }
            else
            {
                var query = (from okolina in _context.Okolina
                             join okolinasmjestaj in _context.OkolinaSmjestaj.Where(x => x.SmjestajId == search.SmjestajId)
                             on okolina.OkolinaId equals okolinasmjestaj.OkolinaId
                             select new OkolinaModel()
                             {
                                 OkolinaId = okolina.OkolinaId,
                                 Naziv = okolina.Naziv,
                                 OkolinaSmjestajId = okolinasmjestaj.OkolinaSmjestajId,
                                 Udaljenost = okolinasmjestaj.Udaljenost,
                                 SmjestajId = okolinasmjestaj.SmjestajId
                             }).ToList();
                if (query.Any())
                {
                    return query;
                }
                else
                    return null;
            }         
        }
        public OkolinaInsertRequest Insert(OkolinaInsertRequest model)
        {
            if (model.Nova)
            {
                Okolina o = _mapper.Map<Okolina>(model);
                _context.Okolina.Add(o);
                _context.SaveChanges();
                OkolinaSmjestaj os = new OkolinaSmjestaj()
                {
                    SmjestajId = model.SmjestajId,
                    OkolinaId = o.OkolinaId,
                    Udaljenost = model.Udaljenost
                };
                _context.OkolinaSmjestaj.Add(os);
                _context.SaveChanges();
            }
            else
            {
                OkolinaSmjestaj os = new OkolinaSmjestaj()
                {
                    SmjestajId = model.SmjestajId,
                    OkolinaId = model.OkolinaId,
                    Udaljenost = model.Udaljenost
                };
                _context.OkolinaSmjestaj.Add(os);
                _context.SaveChanges();
            }
            return model;
        }
        public void Delete(int request)
        {
            OkolinaSmjestaj os = _context.OkolinaSmjestaj.Find(request);
            int OkolinaId = os.OkolinaId;
            _context.OkolinaSmjestaj.Remove(os);
            if ( !_context.OkolinaSmjestaj.Where(x=> x.OkolinaId == OkolinaId).Any())
            {
                Okolina o = _context.Okolina.Find(OkolinaId);
                _context.Okolina.Remove(o);

            }
            _context.SaveChanges();
        }
    }
}
