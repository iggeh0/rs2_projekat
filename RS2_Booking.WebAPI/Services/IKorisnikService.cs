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
        List<Model.KorisnikModel> Get();

        Model.KorisnikModel Insert(KorisnikInsertRequest request);

        Model.KorisnikModel GetById(int id);
        KorisnikEditRequest GetKorisnikEdit(int id);
    }
}
