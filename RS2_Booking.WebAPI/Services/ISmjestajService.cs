
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface ISmjestajService
    {
         List<SmjestajModel> Get(SmjestajSearchRequest request);

        Smjestaj Insert(SmjestajInsertRequest request);

        SmjestajModel GetById(int id);

        SmjestajModel Update(int id, SmjestajModel m);

    }
}
