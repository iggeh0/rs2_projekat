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
    public class InventarService : BaseService<InventarModel, InventarSearchRequest, InventarInsertRequest, Inventar>
    {
        public InventarService(Online_BookingContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override InventarInsertRequest Insert(InventarInsertRequest model)
        {
            Inventar i = new Inventar
            {
                Naziv = model.Naziv
            };
            _context.Inventar.Add(i);
            _context.SaveChanges();
            InventarSoba obj = new InventarSoba
            {
                InventarId = i.InventarId,
                SobaId = model.SobaId
            };
            _context.InventarSoba.Add(obj);
            _context.SaveChanges();
            model.InventarSobaId = obj.InventarSobaId;
            return model;
        }
        public override List<InventarModel> Get(InventarSearchRequest request)
        {

            var query = (from inventar in _context.Inventar
                         join inventarsoba in _context.InventarSoba.Where(x => x.SobaId == request.SobaId)
                         on inventar.InventarId equals inventarsoba.InventarId
                         select new InventarModel()
                         {
                             InventarId = inventar.InventarId,
                             Naziv = inventar.Naziv,
                             SobaId = request.SobaId,
                             InventarSobaId = inventarsoba.InventarSobaId
                         }).ToList();
                   
            return query;
        }

        public override void Delete(int id)
        {
            var entity = _context.InventarSoba.Find(id);
            _context.InventarSoba.Remove(entity);
            _context.SaveChanges();
        }

    }
}
