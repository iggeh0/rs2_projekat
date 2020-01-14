using AutoMapper;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Exceptions;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public class SobaService : ISobaService
    {
        private readonly Online_BookingContext _context;
        private readonly IMapper _mapper;

        public SobaService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<SobaModel> Get(SobaSearchRequest search)
        {
            if (search.SmjestajId > 0 && search.BrojOdraslih == 0)
            {
                var lista = _context.Soba.Where(x => x.SmjestajId == search.SmjestajId).ToList();

                return _mapper.Map<List<SobaModel>>(lista);
            }
            else
            if ( search.BrojOdraslih > 0 )
            {
                List<Soba> lista = _context.Soba.Where(x => x.SmjestajId == search.SmjestajId).ToList();

                foreach ( Soba s in lista )
                {
                    List<RezervacijaSoba> rs = _context.RezervacijaSoba.Where(x => x.SobaId == s.SobaId).ToList();
                    foreach ( RezervacijaSoba rezervacijaSoba in rs )
                    {
                        Rezervacija r = _context.Rezervacija.Find(rezervacijaSoba.RezervacijaId);
                        if ( r.StatusRezervacijeId == 2 && (r.RezervacijaDo > search.DatumOd && r.RezervacijaOd < search.DatumDo) )
                        {
                            lista.Remove(s);
                        }
                    }
                }

                return _mapper.Map<List<SobaModel>>(lista);
            }
            return null;
        }
        public void Delete(int id)
        {
            Soba S = _context.Soba.Find(id);
            if (_context.RezervacijaSoba.Where(x => x.SobaId == S.SobaId).Any())
            {
                throw new UserException("Nije dozvoljeno ukloniti rezervisane sobe");
            }
            else
            {
                _context.InventarSoba.RemoveRange(_context.InventarSoba.Where(x => x.SobaId == S.SobaId));
                _context.Soba.Remove(S);
                _context.SaveChanges();
            }
        }

        public SobaModel GetById(int id)
        {
            return _mapper.Map<SobaModel>(_context.Soba.Find(id));
        }

        public SobaInsertRequest Insert(SobaInsertRequest model)
        {
            if ( model.SobaId == 0 )
            {
                Soba s = _mapper.Map<Soba>(model);
                _context.Soba.Add(s);
                _context.SaveChanges();
            }
            return model;
        }

        public SobaModel Update(SobaModel model, int id)
        {
            Soba s = _context.Soba.Find(id);
            s.BrojKreveta = model.BrojKreveta;
            s.Cijena = model.Cijena;
            s.Opis = model.Opis;
            s.VelicinaSobe = model.VelicinaSobe;
            s.VlastitaKupoanica = model.VlastitaKupoanica;
            s.VrstaSmjestaja = model.VrstaSmjestaja;
            _context.SaveChanges();
            return model;
        }
    }
}
