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
    public class RezervacijaService : IRezervacijaService
    {
        public readonly Online_BookingContext _context;
        public readonly IMapper _mapper;

        public RezervacijaService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Delete(int id)
        {
            Rezervacija r = _context.Rezervacija.Find(id);
            if ( r.StatusRezervacijeId != 1 )
            {
                return;
            }
            _context.Rezervacija.Remove(r);
            _context.SaveChanges();
        }

        public List<RezervacijaModel> Get(RezervacijaSearchRequest search)
        {
            Klijent k = _context.Klijent.Where(x => x.KorisnikId == search.KlijentId).FirstOrDefault();
            var lista = _context.Rezervacija.Where(x => x.KlijentId == k.KlijentId).ToList();

            List<RezervacijaModel> Konacna = new List<RezervacijaModel>();

            foreach ( Rezervacija r in lista )
            {
                RezervacijaModel model = _mapper.Map<RezervacijaModel>(r);
                model.StatusRezervacijeNaziv = _context.StatusRezervacije.Find(r.StatusRezervacijeId).Naziv;
                RezervacijaSoba rs = _context.RezervacijaSoba.Where(x => x.RezervacijaId == r.RezervacijaId).SingleOrDefault();
                Soba soba = _context.Soba.Find(rs.SobaId);
                Smjestaj s = _context.Smjestaj.Find(soba.SmjestajId);
                model.NazivSmjestaja = s.Naziv;
                model.AdresaSmjestaja = s.Adresa + ", " + _context.Grad.Find(s.GradId).Naziv;

                Konacna.Add(model);
            }
            return Konacna;

        }

        public RezervacijaModel GetById(int id)
        {
            if (id > 0)
            {
                return _mapper.Map<RezervacijaModel>(_context.Rezervacija.Find(id));
            }
            else
                return null;
        }

        public RezervacijaInsertRequest Insert(RezervacijaInsertRequest model)
        {
            Klijent k = _context.Klijent.Where(x => x.KorisnikId == model.KlijentId).SingleOrDefault();
            Rezervacija r = new Rezervacija
            {
                BrojDjece = model.BrojDjece,
                BrojOdraslih = model.BrojOdraslih,
                KlijentId = k.KlijentId,
                RezervacijaDo = model.RezervacijaDo,
                RezervacijaOd = model.RezervacijaOd,
                StatusRezervacijeId = 1,
                DatumRezervacije = model.DatumRezervacije,
            };
            _context.Rezervacija.Add(r);
            _context.SaveChanges();
            foreach ( SobaModel s in model.Sobe )
            {
                RezervacijaSoba rs = new RezervacijaSoba
                {
                    SobaId = s.SobaId,
                    RezervacijaId = r.RezervacijaId
                };
                _context.RezervacijaSoba.Add(rs);
            }
            _context.SaveChanges();
            return model;
        }

    }
}
