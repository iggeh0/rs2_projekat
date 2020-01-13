using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Exceptions;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

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
            {
                SmjestajService smjestajService = new SmjestajService(_context, _mapper);
                foreach ( Smjestaj s in _context.Smjestaj.Where(x=> x.IzdavacId ==cascade_entity_2.IzdavacId ))
                    {
                         smjestajService.Delete(s.SmjestajId);
                     }
                _context.Izdavac.Remove(cascade_entity_2);
            }

            _context.Set<Korisnik>().Remove(entity);
            _context.SaveChanges();
        }

        public KorisnikEditRequest Update(KorisnikEditRequest model, int id)
        {
            if (model.Sifra == model.SifraPonovo)
            {
                var user = _context.Korisnik.FirstOrDefault(x => x.KorisnickoIme == model.KorisnickoIme);

                if (user != null)
                {
                    if ( _context.Korisnik.Where(x=> x.KorisnickoIme == model.KorisnickoIme).Any() )
                    {
                        model.Response = "Korisničko ime je zauzeto";
                        return model;
                    }
                    user.Ime = model.Ime;
                    user.Prezime = model.Prezime;
                    user.BrojTelefona = model.BrojTelefona;
                    user.Email = model.Email;
                    user.KorisnickoIme = model.KorisnickoIme;


                    var newHash = GenerateHash(user.SifraSalt, model.Sifra);

                    if (newHash == user.SifraHash)
                    {
                        user.SifraSalt = GenerateSalt();
                        user.SifraHash = GenerateHash(user.SifraSalt, model.Sifra);
                        _context.Set<Korisnik>().Attach(user);
                        _context.Set<Korisnik>().Update(user);

                        _context.SaveChanges();
                    }
                }
                return model;
            }
            else
                return null;
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

            k.SifraSalt = GenerateSalt();
            k.SifraHash = GenerateHash(k.SifraSalt, request.Sifra);
            if ( request.Role == 2 )
            {
                k.IsAdmin = true;
            }
            if (!_context.Korisnik.Any(x => x.KorisnickoIme == request.KorisnickoIme && x.Email == request.Email))
            {
                _context.Korisnik.Add(k);
                _context.SaveChanges();
                if (request.Role == 3)
                {
                    Klijent novi = new Klijent
                    {
                        KorisnikId = k.KorisnikId
                    };
                    _context.Klijent.Add(novi);
                    _context.SaveChanges();
                }
                else if (request.Role == 1)
                {
                    Izdavac novi = new Izdavac { KorisnikId = k.KorisnikId };
                    _context.Izdavac.Add(novi);
                    _context.SaveChanges();
                }
            }
            else
                request.Response = "Korisničko ime ili e-mail je zauzet!";
            return request;
        }

        List<Model.KorisnikModel> IKorisnikService.Get(KorisnikSearchRequest request)
        {
            if (request.KorisnikId > 0)
            {
                Korisnik k = _context.Korisnik.Where(x => x.KorisnikId == request.KorisnikId).FirstOrDefault();
                List<KorisnikModel> lista = new List<KorisnikModel>
                {
                    _mapper.Map<KorisnikModel>(k)
                };
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
                             KorisnickoIme = korisnik.KorisnickoIme,
                             Uloga = 2
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

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.KorisnikModel Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnik.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.SifraSalt, pass);

                if (newHash == user.SifraHash)
                {
                    KorisnikModel korisnik = _mapper.Map<Model.KorisnikModel>(user);
                    korisnik.OK = true;
                    if ( user.IsAdmin == true )
                    {
                        korisnik.Uloga = 1;
                    }

                    if (_context.Izdavac.Where(x=> x.KorisnikId == user.KorisnikId).FirstOrDefault() != null)
                    {
                        korisnik.Uloga = 0;
                    }
                    else
                        korisnik.Uloga = 2;

                    return korisnik;
                }
            }
            KorisnikModel k = new KorisnikModel
            {
                OK = false,
                Poruka = "Korisnik nije pronađen"
            };
            return k;
        }

        public KorisnikModel Login(LoginRequest request)
        {
            KorisnikModel k = Authenticiraj(request.KorisnickoIme, request.Lozinka);
            if (k.OK)
            {
                if (request.Uloga == 0)
                {
                    Izdavac Izdavac = _context.Izdavac.Where(x => x.KorisnikId == k.KorisnikId).FirstOrDefault();
                    if (Izdavac == null)
                    {
                        k.OK = false;
                        k.Poruka = "Pronađeni korisnik nije izdavač!";
                        return k;
                    }
                    else
                    {
                        k.Uloga = 0;
                        k.IzdavacId = Izdavac.IzdavacId;
                        return k;
                    }
                }
                if (request.Uloga == 1)
                {
                    Korisnik korisnik = _context.Korisnik.Find(k.KorisnikId);
                    if (korisnik.IsAdmin != null && korisnik.IsAdmin == true)
                    {
                        k.Uloga = 1;
                        return k;
                    }
                    else
                    {
                        k.OK = false;
                        k.Poruka = "Pronađeni korisnik nema administratorske privilegije!";
                    }
                }

            }
            return k;
        }

        public KorisnikModel GetSingleKorisnik(KorisnikSearchRequest request)
        {

            if (request.Uloga == 1)
            {
                Izdavac i = _context.Izdavac.Find(request.KorisnikId);
                Korisnik k = _context.Korisnik.Find(i.KorisnikId);
                return _mapper.Map<KorisnikModel>(k);
            }
            else if (request.Uloga == 2)
            {

                Korisnik k = _context.Korisnik.Find(request.KorisnikId);
                return _mapper.Map<KorisnikModel>(k);
            }
            else if (request.Uloga == 3)
            {
                Klijent k = _context.Klijent.Find(request.KorisnikId);
                Korisnik korisnik = _context.Korisnik.Find(k.KorisnikId);
                return _mapper.Map<KorisnikModel>(korisnik);
            }
            else return null;
        }
    }
}