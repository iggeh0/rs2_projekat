using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class RezervacijeVM:BaseViewModel
    {
        public KorisnikModel sacuvani = null;
        private readonly API_Service_Mobile _rezervacijaService = new API_Service_Mobile("rezervacija");

        public RezervacijeVM()
        {

        }
        public ObservableCollection<RezervacijaModel> Rezervacije { get; set; } = new ObservableCollection<RezervacijaModel>();

        public async Task Ucitaj()
        {
            RezervacijaSearchRequest request = new RezervacijaSearchRequest();
            request.KlijentId = sacuvani.KorisnikId;
            var lista = await _rezervacijaService.Get<List<RezervacijaModel>>(request);

            if ( lista.Count > 0 )
            {
                foreach (RezervacijaModel r in lista)
                    Rezervacije.Add(r);
            }
        }
    }
}
