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
    public class UslugaService : IUslugaService
    {
        private readonly Online_BookingContext _context;
        private readonly IMapper _mapper;

        public UslugaService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<UslugaModel> Get(UslugaSearchRequest search)
        {
            if (search.Preporucene)
            {
                var query = (from usluga in _context.Usluga
                             join uslugasmjestaj in _context.UslugaSmjestaj.Where(x => x.SmjestajId != search.SmjestajId)
                             on usluga.UslugaId equals uslugasmjestaj.UslugaId
                             select new UslugaModel()
                             {
                                 UslugaId = usluga.UslugaId,
                                 Naziv = usluga.Naziv,
                                 UslugaSmjestajId = uslugasmjestaj.UslugaSmjestajId,
                                 Opis = usluga.Opis
                             }).ToList();
                if (query.Any())
                {
                    return query;
                }
                else
                    return null;
            }
            else
            {
                var query = (from usluga in _context.Usluga
                             join uslugasmjestaj in _context.UslugaSmjestaj.Where(x => x.SmjestajId == search.SmjestajId)
                             on usluga.UslugaId equals uslugasmjestaj.UslugaId
                             select new UslugaModel()
                             {
                                 UslugaId = usluga.UslugaId,
                                 Naziv = usluga.Naziv,
                                 UslugaSmjestajId = uslugasmjestaj.UslugaSmjestajId,
                                 Opis = usluga.Opis
                             }).ToList();
                if (query.Any())
                {
                    return query;
                }
                else
                    return null;
            }
        }
        public UslugaInsertRequest Insert(UslugaInsertRequest model)
        {
            if (model.Nova)
            {
                Usluga u = _mapper.Map<Usluga>(model);
                _context.Usluga.Add(u);
                _context.SaveChanges();
                UslugaSmjestaj us = new UslugaSmjestaj()
                {
                    SmjestajId = model.SmjestajId,
                    UslugaId = u.UslugaId
                };

                _context.UslugaSmjestaj.Add(us);
                _context.SaveChanges();
                return model;
            }
            else
            {
                UslugaSmjestaj us = new UslugaSmjestaj
                {
                    SmjestajId = model.SmjestajId,
                    UslugaId = model.UslugaId
                };
                _context.UslugaSmjestaj.Add(us);
                _context.SaveChanges();
                return model;
            }
        }
        public void Delete(int id)
        {
            UslugaSmjestaj us = _context.UslugaSmjestaj.Find(id);
            int UslugaId = us.UslugaId;
            _context.UslugaSmjestaj.Remove(us);
            if (!_context.UslugaSmjestaj.Where(x => x.UslugaId == UslugaId).Any())
            {
                Usluga u = _context.Usluga.Find(UslugaId);
                _context.Usluga.Remove(u);

            }
            _context.SaveChanges();
        }
    }
}
