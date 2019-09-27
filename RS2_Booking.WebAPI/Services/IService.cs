using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface IService<TModel, TSearch>
    {
        List<TModel> Get(TSearch search);

        TModel GetById(int id);

        TModel Insert(TModel model);

        TModel Update(TModel model, int id);

        void Remove(int id);
    }
}
