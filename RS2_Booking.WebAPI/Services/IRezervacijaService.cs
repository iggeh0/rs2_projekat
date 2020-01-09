using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface IRezervacijaService
    {
        List<RezervacijaModelShort> Get(RezervacijaSearchRequest search);

        RezervacijaModel GetById(int id);

        RezervacijaInsertRequest Insert(RezervacijaInsertRequest model);

        void Delete(int id);
    }
}
