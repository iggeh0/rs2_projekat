using AutoMapper;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Exceptions;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Doraditi kada su rađene rezervacije

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
        public override void Delete(int id)
        {
            var query = (from smjestaj in _context.Smjestaj.Where(x=> x.SmjestajId == id)
                        join soba in _context.Soba
                        on smjestaj.SmjestajId equals soba.SobaId
                        join rezervacijasoba in _context.RezervacijaSoba
                        on soba.SobaId equals rezervacijasoba.SobaId
                        join Rezervacija in _context.Rezervacija
                        on rezervacijasoba.RezervacijaId equals Rezervacija.RezervacijaId
                         where Rezervacija.StatusRezervacijeId != 1 && Rezervacija.StatusRezervacijeId != 1002
                         select new RezervacijaModel()
                         {
                             StatusRezervacijeId = Rezervacija.StatusRezervacijeId
                         }).ToList();
            if ( query.Any() )
            {
                throw new UserException("Nije dozvoljeno uklanjati rezervisane smještaje");
            }

            else
            {
                OkolinaService okolinaService = new OkolinaService(_context, _mapper);
                foreach ( OkolinaSmjestaj os in _context.OkolinaSmjestaj.Where(x=> x.SmjestajId == id) )
                {
                    okolinaService.Delete(os.OkolinaSmjestajId);
                }

                UslugaService uslugaService = new UslugaService(_context, _mapper);
                foreach ( UslugaSmjestaj us in _context.UslugaSmjestaj.Where(x=> x.SmjestajId == id) )
                {
                    uslugaService.Delete(us.UslugaSmjestajId);
                }
                SobaService sobaService = new SobaService(_context, _mapper);
                foreach ( Soba s in _context.Soba.Where(x=> x.SmjestajId == id ))
                { 
                    sobaService.Delete(s.SobaId);
                }
                Smjestaj obj = _context.Smjestaj.Find(id);
                _context.Smjestaj.Remove(obj);
                _context.SaveChanges();
            }
        }
    }
}
