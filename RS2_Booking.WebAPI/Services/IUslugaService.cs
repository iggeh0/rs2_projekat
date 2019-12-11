using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface IUslugaService
    {
        List<UslugaModel> Get(UslugaSearchRequest search);
        UslugaInsertRequest Insert(UslugaInsertRequest model);

        void Delete(int request);
    }
}
