using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface IService<TModel, TSearch, TInsertModel>
    {
        List<TModel> Get(TSearch search);

        TModel GetById(int id);

        TInsertModel Insert(TInsertModel model);

        TModel Update(TModel model, int id);

        void Delete(int id);
    }
}
