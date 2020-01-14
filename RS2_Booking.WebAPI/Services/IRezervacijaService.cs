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
        List<RezervacijaModel> Get(RezervacijaSearchRequest search);

        RezervacijaModel GetById(int id);

        RezervacijaInsertRequest Insert(RezervacijaInsertRequest model);
        List<RezervacijaModel> GetAllForIzdavac(RezervacijaSearchRequest search);
        void Delete(int id);

        void PromjeniStatus(int RezervacijaId, int StatusId);

        List<UplataModel> DodajUplatu(UplataInsertRequest request);

        List<UplataModel> GetUplate(UplataModel request);
    }
}
