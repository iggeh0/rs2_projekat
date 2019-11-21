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

        public void Delete(int id)
        {
            var entity = _context.Set<Korisnik>().Find(id);

            Klijent cascade_entity = _context.Klijent.Where(x => x.KorisnikId == entity.KorisnikId).FirstOrDefault();
            if ( cascade_entity != null )
            _context.Klijent.Remove(cascade_entity);

            Izdavac cascade_entity_2 = _context.Izdavac.Where(x => x.KorisnikId == entity.KorisnikId).FirstOrDefault();

            if (cascade_entity_2 != null)
                _context.Izdavac.Remove(cascade_entity_2);

            _context.Set<Korisnik>().Remove(entity);
            _context.SaveChanges();
        }

        public KorisnikModel Update(KorisnikModel model, int id)
        {
            var entity = _context.Set<Korisnik>().Find(id);

            _context.Set<Korisnik>().Attach(entity);
            _context.Set<Korisnik>().Update(entity);
            _mapper.Map(model, entity);


            _context.SaveChanges();
            return _mapper.Map<KorisnikModel>(entity);
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

        public KorisnikInsertRequest Insert(KorisnikInsertRequest request)
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
            return request;
        }

        List<Model.KorisnikModel> IKorisnikService.Get(KorisnikSearchRequest request)
        {

            if (request.KorisnikId > 0)
            {
                Korisnik k = _context.Korisnik.Where(x => x.KorisnikId == request.KorisnikId).FirstOrDefault();
                List<KorisnikModel> lista = new List<KorisnikModel>();
                lista.Add(_mapper.Map<KorisnikModel>(k));
                return lista;
            }
            else
            {
                var query = _context.Korisnik.AsQueryable();
                if (!string.IsNullOrEmpty(request.Ime))
                {
                    query = query.Where(x => x.Ime.Contains(request.Ime));
                }
                if (!string.IsNullOrEmpty(request.Prezime))
                {
                    query = query.Where(x => x.Prezime.Contains(request.Prezime));
                }
                if (!string.IsNullOrEmpty(request.KorisnickoIme))
                {
                    query = query.Where(x => x.KorisnickoIme.Contains(request.KorisnickoIme));
                }
                List<Korisnik> lista;
                if (!query.Any())
                {
                    lista = _context.Korisnik.ToList();
                }
                else
                {
                    lista = query.ToList();
                }

                var novalista = _mapper.Map<List<KorisnikModel>>(lista);
                return novalista;
            }
          

        }

        public List<KorisnikModel> GetIzdavaci(KorisnikSearchRequest request)
        {
            var query = (from korisnik in _context.Korisnik
                         join izdavac in _context.Izdavac
                         on korisnik.KorisnikId equals izdavac.KorisnikId
                         select new KorisnikModel()                                                                                                                                                                                                                          
                         {
                             KorisnikId = korisnik.KorisnikId,
                             Ime = korisnik.Ime,
                             Prezime = korisnik.Prezime,
                             KorisnickoIme = korisnik.KorisnickoIme
                         }).ToList();
            if (!string.IsNullOrEmpty(request.Ime))                                                                                                                                                                                                                                                                                                                                         
            {
                query = query.Where(x => x.Ime.Contains(request.Ime)).ToList();
            }
            if (!string.IsNullOrEmpty(request.Prezime))
            {
                query = query.Where(x => x.Prezime.Contains(request.Prezime)).ToList();
            }
            if (!string.IsNullOrEmpty(request.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.Contains(request.KorisnickoIme)).ToList();
            }

            return query;
        }
    }
}