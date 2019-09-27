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
    public class SobaService : BaseService<SobaModel, SobaSearchRequest, Soba>
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
    }
}
