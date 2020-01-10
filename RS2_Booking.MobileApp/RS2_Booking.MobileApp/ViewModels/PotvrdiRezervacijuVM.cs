using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class PotvrdiRezervacijuVM
    {
        private readonly API_Service_Mobile _korisnikService = new API_Service_Mobile("korisnik/getsinglekorisnik");
        private readonly API_Service_Mobile _SmjestajService = new API_Service_Mobile("Smjestaj");


        public async void Ucitaj()
        {
            KorisnikSearchRequest korisnikSearchRequest = new KorisnikSearchRequest
            {
                Uloga = 3,
                KorisnikId = KlijentId
            };
            KorisnikModel k = await _korisnikService.Get<KorisnikModel>(korisnikSearchRequest);
            KorisnickoImeKlijenta = k.KorisnickoIme;
            ImeKlijenta = k.Ime;
            PrezimeKlijenta = k.Prezime;
            
        }

        #region model
        public int StatusRezervacijeId { get; set; }
        public string StatusRezervacijeNaziv { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime RezervacijaOd { get; set; }
        public DateTime RezervacijaDo { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public int KlijentId { get; set; }
        public string ImeKlijenta { get; set; }
        public string PrezimeKlijenta { get; set; }
        public string KorisnickoImeKlijenta { get; set; }
        public int SmjestajId { get; set; }
        public string NazivSmjestaja { get; set; }
        public string AdresaSmjestaja { get; set; }
        public List<SobaModel> Sobe { get; set; }
        #endregion
    }
}
