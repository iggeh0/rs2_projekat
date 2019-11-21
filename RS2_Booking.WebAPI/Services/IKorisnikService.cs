using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Services
{
    public interface IKorisnikService
    {
        List<Model.KorisnikModel> Get(KorisnikSearchRequest request);
        List<Model.KorisnikModel> GetIzdavaci(KorisnikSearchRequest request);

        KorisnikInsertRequest Insert(KorisnikInsertRequest request);

        Model.KorisnikModel GetById(int id);
        KorisnikEditRequest GetKorisnikEdit(int id);

        Model.KorisnikModel Update(Model.KorisnikModel model, int id);

        void Delete(int id);
    }
}