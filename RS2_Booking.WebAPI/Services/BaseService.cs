using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TInsertModel, TDatabase> : IService<TModel, TSearch, TInsertModel> where TDatabase: class
    {
        public readonly Online_BookingContext _context;
        public readonly IMapper _mapper;

        public BaseService(Online_BookingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

         public virtual List<TModel> Get(TSearch search)
        {
            var lista = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(lista);
        }

        public virtual TModel GetById(int id)
        {
            var target = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(target);
        }

        public virtual TInsertModel Insert(TInsertModel model)
        {
            TDatabase entity = _mapper.Map<TDatabase>(model);
            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
            return model;
        }

        public virtual void Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual TModel Update(TModel model, int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);
            _mapper.Map(model, entity);


            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }
    }
}
