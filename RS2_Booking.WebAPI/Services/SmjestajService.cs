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
    public class SmjestajService : BaseService<SmjestajModel, SmjestajSearchRequest,  SmjestajInsertRequest, Smjestaj>
    {
        public SmjestajService(Online_BookingContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<SmjestajModel> Get(SmjestajSearchRequest request)
        {
            var query = _context.Smjestaj.AsQueryable();
            if (request.GradId > 0)
            {
                query = query.Where(x => x.GradId == request.GradId);
            }
            if (!(string.IsNullOrWhiteSpace(request.Naziv)))
            {
                query = query.Where(x => x.Naziv.Contains(request.Naziv));
            }

            if (request.IzdavacId > 0)
            {
                query = query.Where(x => x.IzdavacId == request.IzdavacId);
            }

            var lista = query.ToList();

            var novalista = _mapper.Map<List<SmjestajModel>>(lista);

            foreach (SmjestajModel sm in novalista)
            {
                sm.GradNaziv = _context.Grad.Where(x => x.GradId == sm.GradId).SingleOrDefault().Naziv;
            }

            return novalista;
        }

        public override SmjestajModel GetById(int id)
        {
            var m = _context.Smjestaj.Find(id);
           var nova = _mapper.Map<SmjestajModel>(m);
            SmjestajModel Model = new SmjestajModel();
            Model = nova;
            Model.GradNaziv = _context.Grad.Where(x => x.GradId == Model.GradId).SingleOrDefault().Naziv;
            return Model;
        }
    }
}
