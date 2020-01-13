using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface ISmjestajService
    {
         SmjestajModelFull GetFullSmjestaj(int id);
         List<SmjestajModel> Get(SmjestajSearchRequest request);
         SmjestajModel GetById(int id);
         void Delete(int id);
        SmjestajInsertRequest Insert(SmjestajInsertRequest request);

        SmjestajModel Update(SmjestajModel request);

        SlikaModel InsertImage(SlikaModel model);
        List<SlikaModel> GetImages(int smjestajId);
    }
}
