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

        public void PromjeniStatus(int RezervacijaId, int StatusId)
        {
            Rezervacija r = _context.Rezervacija.Find(RezervacijaId);
            r.StatusRezervacijeId = StatusId;
            _context.SaveChanges();
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
                model.RezervacijaDoShort = r.RezervacijaDo.ToShortDateString();
                model.RezervacijaOdShort = r.RezervacijaOd.ToShortDateString();
                model.DatumRezervacijeShort = r.DatumRezervacije.ToShortDateString();
                model.StatusRezervacijeNaziv = _context.StatusRezervacije.Find(r.StatusRezervacijeId).Naziv;
                RezervacijaSoba rs = _context.RezervacijaSoba.Where(x => x.RezervacijaId == r.RezervacijaId).FirstOrDefault();
                Soba soba = _context.Soba.Find(rs.SobaId);
                Smjestaj s = _context.Smjestaj.Find(soba.SmjestajId);
                model.NazivSmjestaja = s.Naziv;
                model.AdresaSmjestaja = s.Adresa + ", " + _context.Grad.Find(s.GradId).Naziv;

                Konacna.Add(model);
            }
            return Konacna;

        }

        public List<RezervacijaModel> GetAllForIzdavac(RezervacijaSearchRequest search)
        {
            Izdavac i = _context.Izdavac.Where(x => x.KorisnikId == search.KlijentId).FirstOrDefault();

            List<RezervacijaModel> Lista = new List<RezervacijaModel>();

            List<Smjestaj> Smjestaji = new List<Smjestaj>();

            Smjestaji = _context.Smjestaj.Where(x => x.IzdavacId == i.IzdavacId).ToList();

            var Sobe = _context.Soba.Where(x => Smjestaji.Any(s => s.SmjestajId == x.SmjestajId));
            var rs = _context.RezervacijaSoba.Where(x => Sobe.Any(s => s.SobaId == x.SobaId));

            var final = _context.Rezervacija.Where(x => rs.Any(s => s.RezervacijaId == x.RezervacijaId));

            List<RezervacijaModel> Konacna = new List<RezervacijaModel>();

            foreach ( Rezervacija r in final )
            {
                RezervacijaModel model = _mapper.Map<RezervacijaModel>(r);
                model.RezervacijaDoShort = r.RezervacijaDo.ToShortDateString();
                model.RezervacijaOdShort = r.RezervacijaOd.ToShortDateString();
                model.DatumRezervacijeShort = r.DatumRezervacije.ToShortDateString();
                model.StatusRezervacijeNaziv = _context.StatusRezervacije.Find(r.StatusRezervacijeId).Naziv;
                RezervacijaSoba rezervacijaSoba = rs.Where(x => x.RezervacijaId == r.RezervacijaId).FirstOrDefault();
                Soba soba = Sobe.Where(x=> x.SobaId == rezervacijaSoba.SobaId).FirstOrDefault();
                Smjestaj s = Smjestaji.Where(x=> x.SmjestajId == soba.SmjestajId).FirstOrDefault();
                model.NazivSmjestaja = s.Naziv;
                model.AdresaSmjestaja = s.Adresa + ", " + _context.Grad.Find(s.GradId).Naziv;
                model.SmjestajId = s.SmjestajId;
                Klijent k = _context.Klijent.Find(r.KlijentId);
                Korisnik korisnik = _context.Korisnik.Find(k.KorisnikId);
                model.ImeKlijenta = korisnik.Ime;
                model.PrezimeKlijenta = korisnik.Prezime;
                model.KorisnickoImeKlijenta = korisnik.KorisnickoIme;
                Konacna.Add(model);
            }

            return Konacna;
        }

        public RezervacijaModel GetById(int id)
        {
            if (id > 0)
            {
                RezervacijaModel model = new RezervacijaModel();
                Rezervacija r = _context.Rezervacija.Find(id);
                model = _mapper.Map<RezervacijaModel>(r);
                model.RezervacijaDoShort = r.RezervacijaDo.ToShortDateString();
                model.RezervacijaOdShort = r.RezervacijaOd.ToShortDateString();
                model.DatumRezervacijeShort = r.DatumRezervacije.ToShortDateString();
                model.StatusRezervacijeNaziv = _context.StatusRezervacije.Find(r.StatusRezervacijeId).Naziv;
                model.Sobe = new List<SobaModel>();
                List<RezervacijaSoba> rezervacijaSoba = _context.RezervacijaSoba.Where(x => x.RezervacijaId == r.RezervacijaId).ToList();
                foreach ( RezervacijaSoba rs in rezervacijaSoba )
                {
                    Soba s = _context.Soba.Find(rs.SobaId);
                    model.Sobe.Add(_mapper.Map<SobaModel>(s));
                }


                Smjestaj smjestaj = _context.Smjestaj.Where(x => x.SmjestajId == model.Sobe[0].SmjestajId).FirstOrDefault();
                model.NazivSmjestaja = smjestaj.Naziv;
                model.AdresaSmjestaja = smjestaj.Adresa + ", " + _context.Grad.Find(smjestaj.GradId).Naziv;
                model.SmjestajId = smjestaj.SmjestajId;

                Klijent k = _context.Klijent.Find(r.KlijentId);
                Korisnik korisnik = _context.Korisnik.Find(k.KorisnikId);
                model.ImeKlijenta = korisnik.Ime;
                model.PrezimeKlijenta = korisnik.Prezime;
                model.KorisnickoImeKlijenta = korisnik.KorisnickoIme;

                model.Uplate = _mapper.Map<List<UplataModel>>(_context.Uplata.Where(x => x.RezervacijaId == id).ToList());

                return model;
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

        public List<UplataModel> DodajUplatu(UplataInsertRequest request)
        {
            Uplata u = new Uplata
            {
                DatumUplate = request.DatumUplate,
                Iznos = request.Iznos,
                RezervacijaId = request.RezervacijaId,
                SifraUplate = GenerateString(8)
            };
            if ( request.KreditnaKartica != null )
            {
                KreditnaKartica k = new KreditnaKartica();
                k.BrojKartice = request.KreditnaKartica.BrojKartice;
                k.GodinaIsteka = request.KreditnaKartica.GodinaIsteka;
                k.MjesecIsteka = request.KreditnaKartica.MjesecIsteka;
                k.TipKartice = request.KreditnaKartica.TipKartice;
                _context.KreditnaKartica.Add(k);
            }
            else
            {
                u.KreditnaKarticaId = 1;
            }
            _context.Uplata.Add(u);
            _context.SaveChanges();

            var Lista = _context.Uplata.Where(x => x.RezervacijaId == request.RezervacijaId).ToList();

            return _mapper.Map<List<UplataModel>>(Lista);
        }

        Random rand = new Random();

        public const string Alphabet =
        "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string GenerateString(int size)
        {
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
            }
            return new string(chars);
        }

        public List<UplataModel> GetUplate(UplataModel request)
        {
            var query = _context.Uplata.AsQueryable();
            if (request.RezervacijaId > 0)
            {
                query = query.Where(x => x.RezervacijaId == request.RezervacijaId);
            }
            if (!(string.IsNullOrWhiteSpace(request.SifraUplate)))
            {
                query = query.Where(x => x.SifraUplate.Contains(request.SifraUplate));
            }     
            var lista = query.ToList();

            List<UplataModel> novalista = new List<UplataModel>();
            foreach (Uplata u in lista)
            {
                UplataModel un = new UplataModel
                {
                    DatumUplate = u.DatumUplate,
                    Iznos = u.Iznos,
                    RezervacijaId = u.RezervacijaId,
                    SifraUplate = u.SifraUplate,
                    UplataId = u.UplataId
                };
            }

            return novalista;
        }
    }
}
