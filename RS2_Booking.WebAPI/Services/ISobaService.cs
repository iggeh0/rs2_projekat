using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface ISobaService
    {
        List<SobaModel> Get(SobaSearchRequest search);

        SobaModel GetById(int id);

        SobaInsertRequest Insert(SobaInsertRequest model);

        SobaModel Update(SobaModel model, int id);

        void Delete(int id);
    }
}
