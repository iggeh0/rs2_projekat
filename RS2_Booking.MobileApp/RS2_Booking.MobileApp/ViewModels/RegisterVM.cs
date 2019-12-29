using Nest;
using RS2_Booking.MobileApp.Views;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xunit;
using Xunit.Sdk;

namespace RS2_Booking.MobileApp.ViewModels
{

    public class RegisterVM : BaseViewModel
    {
        private readonly API_Service_Mobile service = new API_Service_Mobile("korisnik");


        #region Podaci
        public string _Ime = string.Empty;
      
        public string Ime
        {
            get { return _Ime; }
            set { SetProperty(ref _Ime, value); }
        }

        public string _Prezime = string.Empty;

        public string Prezime
        {
            get { return _Prezime; }
            set { SetProperty(ref _Prezime, value); }
        }

        public string _JMBG = string.Empty;

        public string JMBG
        {
            get { return _JMBG; }
            set { SetProperty(ref _JMBG, value); }
        }

        public string _Sifra = string.Empty;

        public string Sifra
        {
            get { return _Sifra; }
            set { SetProperty(ref _Sifra, value); }
        }

        public string _SifraPonovo = string.Empty;
        public string SifraPonovo
        {
            get { return _SifraPonovo; }
            set { SetProperty(ref _SifraPonovo, value); }
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

        public DateTime _DatumRodjenja;

        public DateTime DatumRodjenja
        {
            get { return _DatumRodjenja; }
            set { SetProperty(ref _DatumRodjenja, value); }
        }

        public string _KorisnickoIme = string.Empty;

        public string KorisnickoIme
        {
            get { return _KorisnickoIme; }
            set { SetProperty(ref _KorisnickoIme, value); }
        }
        #endregion
        public RegisterVM()
        {
            RegisterCommand = new Command(async () => await Register());
        }

        public ICommand RegisterCommand { get; set; }



        async Task Register()
        {
            if ( Ime == null || Ime.Length < 3 )
            {
               await Application.Current.MainPage.DisplayAlert("Greška", "Ime nije pravilno uneseno!", "Ok");
               return;
            }
            if (Prezime == null || Prezime.Length < 3)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prezime nije pravilno uneseno!", "Ok");
                return;
            }
            Regex regex = new Regex(@"^\d+$");

            if ( !regex.Match(JMBG).Success || JMBG.Length != 13 )
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "JMBG nije pravilno unesen!", "Ok");
                return;
            }

            bool isPhone = Regex.IsMatch(BrojTelefona, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            if (isPhone || BrojTelefona.Length < 8)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Telefon je neispravno unesen!", "Ok");
                return;
            }

            if (DatumRodjenja != null)
            {
                if (DatumRodjenja > DateTime.Today)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Datum je neispravno unesen!", "Ok");
                    return;
                }
            }

            bool isEmail = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmail || Email.Length < 6)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "E-Mail je neispravno unesen!", "Ok");
                return;
            }

            if (KorisnickoIme == null || KorisnickoIme.Length < 3)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Korisnicko Ime nije pravilno uneseno!", "Ok");
                return;
            }

            if (Sifra == null || Sifra.Length < 6)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Šifra mora biti duža od 6 karaktera!", "Ok");
                return;
            }

            if ( SifraPonovo == Sifra && Sifra != null)
            {
                KorisnikInsertRequest request = new KorisnikInsertRequest
                {
                    Ime = Ime,
                    Prezime = Prezime,
                    Jmbg = JMBG,
                    KorisnickoIme = KorisnickoIme,
                    IsAdmin = false,
                    Sifra = Sifra,
                    Role = 3,
                    Email = Email,
                    BrojTelefona = BrojTelefona,
                    DatumRodjenja = DatumRodjenja
                };
                request = await service.Register<KorisnikInsertRequest>(request);
                if (request.Response == null)
                {
                    Application.Current.MainPage = new LoginPage();
                }
                else
                   await Application.Current.MainPage.DisplayAlert("Greška", request.Response, "OK");
                return;
               
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Šifre nisu iste", "Ok");
                return;
            }
        }

        


    }
}
