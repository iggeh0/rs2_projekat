using RS2_Booking.MobileApp.Views;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class SmjestajVM : BaseViewModel
    {

        private readonly API_Service_Mobile _smjestajService = new API_Service_Mobile("smjestaj");
        private readonly API_Service_Mobile _korisnikService = new API_Service_Mobile("korisnik/GetSingleKorisnik");

        public int _SmjestajId = 0;


        #region Model
        public int SmjestajId
        {
            get { return _SmjestajId; }
            set { SetProperty(ref _SmjestajId, value); }
        }


        public int _IzdavacId;
        public int IzdavacId
        {
            get { return _IzdavacId; }
            set { SetProperty(ref _IzdavacId, value); }
        }

        public string _ImeIzdavaca;

        public string ImeIzdavaca
        {
            get { return _ImeIzdavaca; }
            set { SetProperty(ref _ImeIzdavaca, value); }
        }

        public string _Naziv;

        public string Naziv
        {
            get { return _Naziv; }
            set { SetProperty(ref _Naziv, value); }
        }

        public double _Distanca;
        public double Distanca
        {
            get { return _Distanca; }
            set { SetProperty(ref _Distanca, value); }
        }

        public string _Opis;

        public string Opis
        {
            get { return _Opis; }
            set { SetProperty(ref _Opis, value); }
        }

        public string _Adresa;

        public string Adresa
        {
            get { return _Adresa; }
            set { SetProperty(ref _Adresa, value); }
        }

        public string _KontaktTelefon;

        public string KontaktTelefon
        {
            get { return _KontaktTelefon; }
            set { SetProperty(ref _KontaktTelefon, value); }
        }

        public string _Email;

        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }

        public int _Zvijezde;

        public int Zvijezde
        {
            get { return _Zvijezde; }
            set { SetProperty(ref _Zvijezde, value); }
        }

        public string _GradNaziv;

        public string GradNaziv
        {
            get { return _GradNaziv; }
            set { SetProperty(ref _GradNaziv, value); }
        }

        #endregion

        public SmjestajVM()
        {
            UcitajCommand = new Command(async () => await Ucitaj());
            IzdavacCommand = new Command(() => GetIzdavac());
        }

        private void GetIzdavac()
        {
            Application.Current.MainPage = new IzdavacViewPage(IzdavacId);
        }

        public ICommand UcitajCommand { get; set; }
        public ICommand IzdavacCommand { get; set; }

        public async Task Ucitaj()
        {
            SmjestajModel Model = await _smjestajService.GetById<SmjestajModel>(_SmjestajId);
            Naziv = Model.Naziv;
            Distanca = Model.Distanca.Value;
            Opis = Model.Opis;
            Adresa = Model.Adresa;
            KontaktTelefon = Model.KontaktTelefon;
            Email = Model.Email;
            if (Model.Zvijezde != null)
            {
                Zvijezde = Model.Zvijezde.Value;
            }
            GradNaziv = Model.GradNaziv;

            IzdavacId = Model.IzdavacId;

            KorisnikSearchRequest request = new KorisnikSearchRequest
            {
                Uloga = 1,
                KorisnikId = IzdavacId
            };
            KorisnikModel Izdavac = await _korisnikService.Get<KorisnikModel>(request);
            ImeIzdavaca = Izdavac.KorisnickoIme;
        }

    }
}
