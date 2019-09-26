using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;

namespace RS2_Booking.WebAPI.Services
{
    public class KorisnikService : IKorisnikService
    {
        private readonly Online_BookingContext _context;
        private readonly IMapper _mapper;

        public KorisnikService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public KorisnikModel GetById(int id)
        {
            var entity = _context.Korisnik.Find(id);
            if (entity != null)
            {
                KorisnikModel korisnik = _mapper.Map<KorisnikModel>(entity);
                return korisnik;
            }
            else
                return null;
        }

        public KorisnikEditRequest GetKorisnikEdit(int id)
        {
            var entity = _context.Korisnik.Find(id);
            if (entity != null)
            {
                KorisnikEditRequest k = _mapper.Map<KorisnikEditRequest>(entity);
                return k;
            }
            else
                return null;
        }

        public Model.KorisnikModel Insert(KorisnikInsertRequest request)
        {
            var k = _mapper.Map<Models.Korisnik>(request);
            k.SifraSalt = "implementiraj";
            k.SifraHash = "implemantiraj";
            _context.Korisnik.Add(k);
            _context.SaveChanges();
            if ( request.Role == 1 )
            {
                Klijent novi = new Klijent
                {
                    KorisnikId = k.KorisnikId
                };
                _context.Klijent.Add(novi);
                _context.SaveChanges();
            }
            else if ( request.Role == 2 )
            {
                Izdavac novi = new Izdavac { KorisnikId = k.KorisnikId };
                _context.Izdavac.Add(novi);
                _context.SaveChanges();
            }
            return _mapper.Map<KorisnikModel>(k);
        }

        List<Model.KorisnikModel> IKorisnikService.Get()
        {
            var lista = _context.Korisnik.ToList();

            return _mapper.Map<List<Model.KorisnikModel>>(lista);
           
        }
    }
}
