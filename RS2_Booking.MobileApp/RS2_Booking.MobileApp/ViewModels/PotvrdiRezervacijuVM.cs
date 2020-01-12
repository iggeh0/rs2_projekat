using RS2_Booking.MobileApp.Views;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class PotvrdiRezervacijuVM : BaseViewModel
    {
        private readonly API_Service_Mobile _korisnikService = new API_Service_Mobile("korisnik/getsinglekorisnik");
        private readonly API_Service_Mobile _rezervacijaService = new API_Service_Mobile("rezervacija");

        public PotvrdiRezervacijuVM()
        {
            PotvrdiCommand = new Command(async() => await Potvrdi());

        }
        public async Task Ucitaj()
        {
            KorisnikSearchRequest korisnikSearchRequest = new KorisnikSearchRequest
            {
                Uloga = 2,
                KorisnikId = KlijentId
            };
            KorisnikModel k = await _korisnikService.Get<KorisnikModel>(korisnikSearchRequest);
            KorisnickoImeKlijenta = k.KorisnickoIme;
            ImeKlijenta = k.Ime;
            PrezimeKlijenta = k.Prezime;            
        }

        #region model
        public int _StatusRezervacijeId;
        public int StatusRezervacijeId
        {
            get { return _StatusRezervacijeId; }
            set { SetProperty(ref _StatusRezervacijeId, value); }
        }
        public string _StatusRezervacijeNaziv;
        public string StatusRezervacijeNaziv
        {
            get { return _StatusRezervacijeNaziv; }
            set { SetProperty(ref _StatusRezervacijeNaziv, value); }
        }
        public DateTime _DatumRezervacije;
        public DateTime DatumRezervacije
        {
            get { return _DatumRezervacije; }
            set { SetProperty(ref _DatumRezervacije, value); }
        }
        public DateTime _RezervacijaOd;
        public DateTime RezervacijaOd
        {
            get { return _RezervacijaOd; }
            set { SetProperty(ref _RezervacijaOd, value); }
        }
        public DateTime _RezervacijaDo;
        public DateTime RezervacijaDo
        {
            get { return _RezervacijaDo; }
            set { SetProperty(ref _RezervacijaDo, value); }
        }
        public int _BrojOdraslih;
        public int BrojOdraslih
        {
            get { return _BrojOdraslih; }
            set { SetProperty(ref _BrojOdraslih, value); }
        }
        public int _BrojDjece;
        public int BrojDjece
        {
            get { return _BrojDjece; }
            set { SetProperty(ref _BrojDjece, value); }
        }
        public int _BrojSoba;
        public int BrojSoba
        {
            get { return _BrojSoba; }
            set { SetProperty(ref _BrojSoba, value); }
        }


        public int _KlijentId;
        public int KlijentId
        {
            get { return _KlijentId; }
            set { SetProperty(ref _KlijentId, value); }
        }
        public string _ImeKlijenta;
        public string ImeKlijenta
        {
            get { return _ImeKlijenta; }
            set { SetProperty(ref _ImeKlijenta, value); }
        }
        public string _PrezimeKlijenta;
        public string PrezimeKlijenta
        {
            get { return _PrezimeKlijenta; }
            set { SetProperty(ref _PrezimeKlijenta, value); }
        }
        public string _KorisnickoImeKlijenta;
        public string KorisnickoImeKlijenta
        {
            get { return _KorisnickoImeKlijenta; }
            set { SetProperty(ref _KorisnickoImeKlijenta, value); }
        }
        public int _SmjestajId;
        public int SmjestajId
        {
            get { return _SmjestajId; }
            set { SetProperty(ref _SmjestajId, value); }
        }
        public string _NazivSmjestaja;
        public string NazivSmjestaja
        {
            get { return _NazivSmjestaja; }
            set { SetProperty(ref _NazivSmjestaja, value); }
        }
        public string _AdresaSmjestaja;
        public string AdresaSmjestaja
        {
            get { return _AdresaSmjestaja; }
            set { SetProperty(ref _AdresaSmjestaja, value); }
        }
        public ObservableCollection<SobaModel> Sobe { get; set; }
        #endregion

        public ICommand PotvrdiCommand { get; set; }
        public async Task Potvrdi()
        {
            RezervacijaInsertRequest request = new RezervacijaInsertRequest
            {
                BrojDjece = BrojDjece,
                BrojOdraslih = BrojOdraslih,
                DatumRezervacije = DatumRezervacije,
                KlijentId = KlijentId,
                RezervacijaDo = RezervacijaDo,
                RezervacijaOd = RezervacijaOd,
                StatusRezervacijeId = 2,
                Sobe = new List<SobaModel>()
            };
            foreach ( SobaModel s in Sobe )
            {
                request.Sobe.Add(s);
            }

            await _rezervacijaService.Insert<RezervacijaInsertRequest>(request);
            KorisnikModel k = returnKorisnik();
            Application.Current.MainPage = new PocetnaPage(k);
        }
        public KorisnikModel returnKorisnik()
        {
            KorisnikModel k = new KorisnikModel
            {
                KorisnikId = KlijentId,
                KorisnickoIme = KorisnickoImeKlijenta,
                Ime = ImeKlijenta,
                Prezime = PrezimeKlijenta
            };
            return k;
        }
    }
}
