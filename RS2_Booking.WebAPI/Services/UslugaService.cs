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
    public class UslugaService : BaseService<UslugaModel, UslugaSearchRequest, UslugaInsertRequest, Usluga>
    {
        public UslugaService(Online_BookingContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<UslugaModel> Get(UslugaSearchRequest search)
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
        public override UslugaInsertRequest Insert(UslugaInsertRequest model)
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
        public override void Delete(int id)
        {
            UslugaSmjestaj us = _context.UslugaSmjestaj.Find(id);
            _context.UslugaSmjestaj.Remove(us);
            _context.SaveChanges();
        }
    }
}
