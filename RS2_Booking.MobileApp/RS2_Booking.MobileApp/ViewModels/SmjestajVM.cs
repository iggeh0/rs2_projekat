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
    public class SmjestajVM : BaseViewModel
    {

        private readonly API_Service_Mobile _smjestajService = new API_Service_Mobile("smjestaj/GetFullSmjestaj");
        public int _SmjestajId = 0;
        public KorisnikModel sacuvani = null;

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

        public int _KorisnikId;
        public int KorisnikId
        {
            get { return _KorisnikId; }
            set { SetProperty(ref _KorisnikId, value); }
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

        public ObservableCollection<UslugaModel> Usluge { get; set; } = new ObservableCollection<UslugaModel>();
        public ObservableCollection<SobaModel> Sobe { get; set; } = new ObservableCollection<SobaModel>();


        #endregion

        public SmjestajVM()
        {
            UcitajCommand = new Command(async () => await Ucitaj());
            IzdavacCommand = new Command(() => GetIzdavac());
            RezervisiCommand = new Command(() => Rezervisi());
        }
        public SmjestajVM(KorisnikModel k)
        {
            UcitajCommand = new Command(async () => await Ucitaj());
            IzdavacCommand = new Command(() => GetIzdavac());
            RezervisiCommand = new Command(() => Rezervisi());
            sacuvani = k;
        }

        private void GetIzdavac()
        {
            Application.Current.MainPage = new IzdavacViewPage(IzdavacId, sacuvani);
        }

        public ICommand UcitajCommand { get; set; }
        public ICommand IzdavacCommand { get; set; }
        public ICommand RezervisiCommand { get; set; }


        public async Task Ucitaj()
        {
            SmjestajSearchRequest request = new SmjestajSearchRequest
            {
                SmjestajId = _SmjestajId
            };
            SmjestajModelFull Model = await _smjestajService.Get<SmjestajModelFull>(request);
            Distanca = Model.Distanca.Value;
            Opis = Model.Opis;
            Adresa = Model.Adresa;
            KontaktTelefon = Model.KontaktTelefon;
            Email = Model.Email;
            Naziv = Model.Naziv;
            if (Model.Zvijezde != null)
            {
                Zvijezde = Model.Zvijezde.Value;
            }
            GradNaziv = Model.GradNaziv;

            IzdavacId = Model.IzdavacId;

            ImeIzdavaca = Model.IzdavacIme;

            if (Model.ListaUsluga != null && Model.ListaUsluga.Count > 0)
            {
                foreach (UslugaModel u in Model.ListaUsluga)
                {
                    Usluge.Add(u);
                }
            }
            if (Model.ListaSoba != null && Model.ListaSoba.Count > 0)
            {
                foreach (SobaModel s in Model.ListaSoba)
                {
                    Sobe.Add(s);
                }
            }


        }


        public void Rezervisi()
        {
            SmjestajModel s = new SmjestajModel
            {
                Naziv = Naziv,
                SmjestajId = SmjestajId,
                GradNaziv = GradNaziv,
                Adresa = Adresa
            };
            Application.Current.MainPage = new RezervisiSmjestajPage(sacuvani, s);

        }
    }
}
