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

        public List<RezervacijaModelShort> Get(RezervacijaSearchRequest search)
        {
            var query = _context.Rezervacija.AsQueryable();
            if (search.KlijentId > 0)
            {
                query = query.Where(x => x.KlijentId == search.KlijentId);
            }
            if (search.DatumDo > new DateTime())
            {
                query = query.Where(x => x.RezervacijaDo == search.DatumDo);
            }

            if (search.DatumOd > new DateTime())
            {
                query = query.Where(x => x.RezervacijaOd == search.DatumOd);
            }

            if ( search.StatusRezervacijeId > 0 )
            {
                query = query.Where(x => x.StatusRezervacijeId == search.StatusRezervacijeId);
            }

            var lista = query.ToList();

            var novalista = _mapper.Map<List<RezervacijaModelShort>>(lista);

            return novalista;
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
            Rezervacija r = new Rezervacija
            {
                BrojDjece = model.BrojDjece,
                BrojOdraslih = model.BrojOdraslih,
                KlijentId = model.KlijentId,
                RezervacijaDo = model.RezervacijaDo,
                RezervacijaOd = model.RezervacijaOd,
                StatusRezervacijeId = 1
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
