using AutoMapper;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Exceptions;
using RS2_Booking.WebAPI.Models;
using RS2_Booking.Model.Report;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Doraditi kada su rađene rezervacije

namespace RS2_Booking.WebAPI.Services
{
    public class SmjestajService : ISmjestajService
    {
        private readonly Online_BookingContext _context;
        private readonly IMapper _mapper;

        public SmjestajService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public SmjestajModelFull GetFullSmjestaj(int id)
        {
            Smjestaj s = _context.Smjestaj.Find(id);
            if ( s != null )
            {
                SmjestajModelFull model = new SmjestajModelFull
                {
                    Naziv = s.Naziv,
                    IzdavacId = s.IzdavacId,
                    GradId = s.GradId,
                    GradNaziv = _context.Grad.Find(s.GradId).Naziv,
                    Adresa = s.Adresa,
                    Distanca = s.Distanca,
                    Email = s.Email,
                    KontaktTelefon = s.KontaktTelefon,
                    Opis = s.Opis,
                    Zvijezde = s.Zvijezde
                };

                UslugaService uslugaService = new UslugaService(_context, _mapper);

                UslugaSearchRequest uslugaSearch = new UslugaSearchRequest
                {
                    SmjestajId = id
                };
                model.ListaUsluga = uslugaService.Get(uslugaSearch);

                SobaService sobaService = new SobaService(_context, _mapper);

                SobaSearchRequest sobaSearch = new SobaSearchRequest
                {
                    SmjestajId = id
                };

                model.ListaSoba = sobaService.Get(sobaSearch);

                Korisnik k = (from izdavac in _context.Izdavac.Where(x => x.IzdavacId == s.IzdavacId)
                                    join korisnik in _context.Korisnik
                                    on izdavac.KorisnikId equals korisnik.KorisnikId
                                    select new Korisnik()
                                    {
                                        KorisnickoIme = korisnik.KorisnickoIme
                                    }).FirstOrDefault();
                model.IzdavacIme = k.KorisnickoIme;
                model.ListSlika = new List<SlikaModel>();
                foreach ( Slika Slika in _context.Slika.Where(x=> x.SmjestajId == id).ToList())
                {
                    SlikaModel slikaModel = new SlikaModel();
                    slikaModel.SmjestajId = id;
                    slikaModel.SlikaFile = Slika.SlikaFile;
                    model.ListSlika.Add(slikaModel);
                }

                return model;
            }
            SmjestajModelFull PrazanModel = new SmjestajModelFull
            {
                Response = "Smještaj nije pronađen!"
            };
            return PrazanModel;
        }

        public List<SmjestajModel> Get(SmjestajSearchRequest request)
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

        public SmjestajModel GetById(int id)
        {
            var m = _context.Smjestaj.Find(id);
           var nova = _mapper.Map<SmjestajModel>(m);
            SmjestajModel Model = new SmjestajModel();
            Model = nova;
            Model.GradNaziv = _context.Grad.Where(x => x.GradId == Model.GradId).SingleOrDefault().Naziv;
            return Model;
        }

        public SmjestajInsertRequest Insert(SmjestajInsertRequest request)
        {
            if ( request.IzdavacId > 0 )
            {
                Smjestaj s = _mapper.Map<Smjestaj>(request);
                _context.Smjestaj.Add(s);
                _context.SaveChanges();
            }
            return request;
        }

        public void Delete(int id)
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

        public SmjestajModel Update(SmjestajModel request)
        {
            Smjestaj s = _context.Smjestaj.Find(request.SmjestajId);

            s.Naziv = request.Naziv;
            s.Opis = request.Opis;
            s.KontaktTelefon = request.KontaktTelefon;
            s.Email = request.Email;
            _context.SaveChanges();
            return request;
        }

        public SlikaModel InsertImage(SlikaModel model)
        {
            Slika s = new Slika
            {
                SmjestajId = model.SmjestajId,
                SlikaFile = model.SlikaFile
            };
            _context.Slika.Add(s);
            _context.SaveChanges();
            return model;
        }

        public List<SlikaModel> GetImages(int smjestajId)
        {
            List<SlikaModel> Lista = new List<SlikaModel>();
            foreach ( Slika s in _context.Slika )
            {
                if ( s.SmjestajId ==  smjestajId )
                {
                    SlikaModel model = new SlikaModel();
                    model.SlikaFile = s.SlikaFile;
                    model.SmjestajId = s.SmjestajId;
                    Lista.Add(model);
                }
            }
            return Lista;
        }

        public IzvjestajModel GetIzvjestaj(int IzdavacId)
        {
            IzvjestajModel Izvjestaj = new IzvjestajModel
            {
                SmjestajDioVar = new List<SmjestajDio>(),
                KorisniciDioVar = new List<KorisniciDio>()
            };
            List<Smjestaj> Smjestaji = _context.Smjestaj.Where(x => x.IzdavacId == IzdavacId).ToList();
            List<Soba> Sobe = _context.Soba.Where(x => Smjestaji.Exists(s => s.SmjestajId == x.SmjestajId)).ToList();

            List<RezervacijaSoba> RS = _context.RezervacijaSoba.Where(x => Sobe.Exists(s => s.SobaId == x.SobaId)).ToList();
            List<Rezervacija> Rezervacije = _context.Rezervacija.Where(x => RS.Exists(s => s.RezervacijaId == x.RezervacijaId)).ToList();
            List<Klijent> Klijenti = _context.Klijent.Where(x => Rezervacije.Exists(s => s.KlijentId == x.KlijentId)).ToList();
            List<Korisnik> Korisnici = _context.Korisnik.Where(x => Klijenti.Exists(s => s.KorisnikId == x.KorisnikId)).ToList();



            foreach (Smjestaj s in Smjestaji)
            {
                SmjestajDio sd = new SmjestajDio();
                sd.NazivSmjestaja = s.Naziv;
                sd.BrojRezervacija = RS.Where(x => Sobe.Any(so => so.SobaId == x.SobaId && so.SmjestajId == s.SmjestajId)).Count();
                List<Soba> SobeSmjestaj = Sobe.Where(x => RS.Exists(so => so.SobaId == x.SobaId)).ToList();
                List<RezervacijaSoba> rs1 = RS.Where(x => SobeSmjestaj.Exists(so => x.SobaId == so.SobaId)).ToList();
                double UkupnaCijena = 0;
                double UkupnaCijenaRezervacije = 0;
                foreach ( Rezervacija r in Rezervacije.Where(x=> rs1.Exists(y=> y.RezervacijaId == x.RezervacijaId)).ToList())
                {
                    UkupnaCijena = 0;
                    UkupnaCijenaRezervacije = 0;
                    DateTime Pocetni = r.RezervacijaOd;
                    DateTime Krajnji = r.RezervacijaDo;

                    int Dani = (Krajnji - Pocetni).Days;
                   
                    foreach (Soba S in Sobe.Where(x=> rs1.Exists(y=> y.SobaId == x.SobaId)).ToList())
                    {
                        UkupnaCijenaRezervacije += S.Cijena * Dani;
                    }
                    UkupnaCijena += UkupnaCijenaRezervacije;
                    sd.Zarada = UkupnaCijena;
                    Izvjestaj.SmjestajDioVar.Add(sd);
                }

            }

            Izvjestaj.SmjestajDioVar.Sort((x, y) => x.Zarada.CompareTo(y.Zarada));


            foreach ( Korisnik k in Korisnici )
            {
                KorisniciDio kd = new KorisniciDio();
                kd.ImePrezime = k.Ime + " " + k.Prezime;
                kd.KorisnickoIme = k.KorisnickoIme;
                Klijent kl = Klijenti.Where(x => x.KorisnikId == k.KorisnikId).FirstOrDefault();
                kd.BrojRezervacija = Rezervacije.Where(x => x.KlijentId == kl.KlijentId).Count();

                Izvjestaj.KorisniciDioVar.Add(kd);
            }

            Izvjestaj.KorisniciDioVar = Izvjestaj.KorisniciDioVar.OrderBy(x => x.BrojRezervacija).ToList();
            Izvjestaj.KorisniciDioVar.Sort((x, y) => x.BrojRezervacija.CompareTo(y.BrojRezervacija));
            return Izvjestaj;

        }
    }
}
