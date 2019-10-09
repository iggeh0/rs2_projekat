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
    public class SobaService : BaseService<SobaModel, SobaSearchRequest, SobaInsertRequest, Soba>
    {
        public SobaService(Online_BookingContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<SobaModel> Get(SobaSearchRequest search)
        {
            if (search.SmjestajId > 0)
            {
                var lista = _context.Soba.Where(x => x.SmjestajId == search.SmjestajId).ToList();

                return _mapper.Map<List<SobaModel>>(lista);
            }
            else
                return null;
        }
        public override void Delete(int id)
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
    }
}
