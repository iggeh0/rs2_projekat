using AutoMapper;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase: class
    {
        public readonly Online_BookingContext _context;
        public readonly IMapper _mapper;

        public BaseService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

         virtual public List<TModel> Get(TSearch search)
        {
            var lista = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(lista);
        }

        virtual public TModel GetById(int id)
        {
            var target = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(target);
        }
    }
}
