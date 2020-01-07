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
    public class IzdavacVM : BaseViewModel
    {
        private readonly API_Service_Mobile _smjestajService = new API_Service_Mobile("smjestaj");
        private readonly API_Service_Mobile _korisnikService = new API_Service_Mobile("korisnik/GetSingleKorisnik");
        public IzdavacVM()
        {
            UcitajCommand = new Command(async () => await Ucitaj());
        }


        public ICommand UcitajCommand { get; set; }

        public async Task Ucitaj()
        {
            KorisnikSearchRequest request = new KorisnikSearchRequest
            {
                Uloga = 1,
                KorisnikId = IzdavacId
            };
            KorisnikModel korisnik = await _korisnikService.Get<KorisnikModel>(request);

            KorisnickoIme = korisnik.KorisnickoIme;
            Email = korisnik.Email;
            BrojTelefona = korisnik.BrojTelefona;
            KorisnikId = korisnik.KorisnikId;
            SmjestajSearchRequest request2 = new SmjestajSearchRequest
            {
                IzdavacId = IzdavacId
            };

            ListaSmjestaja.Clear();

            var source = await _smjestajService.Get<List<SmjestajModel>>(request2);

            if (source.Count > 0)
            {
                foreach (SmjestajModel S in source)
                {
                    ListaSmjestaja.Add(S);
                }
            }
        }


        public int _IzdavacId;
        public int IzdavacId
        {
            get { return _IzdavacId; }
            set { SetProperty(ref _IzdavacId, value); }
        }

        public ObservableCollection<SmjestajModel> ListaSmjestaja { get; set; } = new ObservableCollection<SmjestajModel>();

        public string KorisnickoIme
        {
            get { return _KorisnickoIme; }
            set { SetProperty(ref _KorisnickoIme, value); }
        }

        public string _KorisnickoIme = null;


        public int _KorisnikId;
        public int KorisnikId
        {
            get { return _KorisnikId; }
            set { SetProperty(ref _KorisnikId, value); }
        }

        public string _Email = string.Empty;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }

        public string _BrojTelefona = string.Empty;
        public string BrojTelefona
        {
            get { return _BrojTelefona; }
            set { SetProperty(ref _BrojTelefona, value); }
        }


    }
}
