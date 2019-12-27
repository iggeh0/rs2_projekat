using Nest;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
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

        public RegisterVM()
        {

            RegisterCommand = new Command(async () => await Register());
        }

        ICommand RegisterCommand { get; set; }

        public async Task Register()
        {
            if ( SifraPonovo == Sifra )
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
                    DatumRodjenja = Convert.ToDateTime(DatumRodjenja)
                };
                await service.Insert<KorisnikInsertRequest>(request);
            }
        }

        #region Podaci
        public string _Ime;

        [Required(AllowEmptyStrings =false, ErrorMessage ="Ime ne smije biti prazno!")]
        [MinLength(2, ErrorMessage ="Ime mora biti duže od 2 slova!")]
        public string Ime
        {
            get { return _Ime; }
            set { SetProperty(ref _Ime, value); }
        }

        public string _Prezime;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Prezime ne smije biti prazno!")]
        [MinLength(2, ErrorMessage = "Prezime mora biti duže od 2 slova!")]
        public string Prezime
        {
            get { return _Prezime; }
            set { SetProperty(ref _Prezime, value); }
        }

        public string _JMBG;

        [Required(AllowEmptyStrings = false, ErrorMessage = "JMBG polje ne smije biti prazno!")]
        [MinLength(13, ErrorMessage = "JMBG mora biti tačno 13 brojeva dugačko!")]
        [MaxLength(13, ErrorMessage = "JMBG mora biti tačno 13 brojeva dugačko!")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "JMBG prihvata samo brojeve!")]
        public string JMBG
        {
            get { return _JMBG; }
            set { SetProperty(ref _JMBG, value); }
        }

        public string _Sifra;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Šifra ne smije biti prazna!")]
        [MinLength(6, ErrorMessage = "Šifra mora biti duža od 6 karaktera!")]
        public string Sifra
        {
            get { return _Sifra; }
            set { SetProperty(ref _Sifra, value); }
        }

        public string _SifraPonovo;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Šifra ne smije biti prazna!")]
        [MinLength(6, ErrorMessage = "Šifra mora biti duža od 6 karaktera!")]
        public string SifraPonovo
        {
            get { return _SifraPonovo; }
            set { SetProperty(ref _SifraPonovo, value); }
        }

        public string _Email;
        [Required]
        [EmailAddress(ErrorMessage ="Uneseni e-mail nije validan")]
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }

        public string _BrojTelefona;
        [Required]
        [Phone(ErrorMessage ="Uneseni broj telefona nije validan")]
        public string BrojTelefona
        {
            get { return _BrojTelefona; }
            set { SetProperty(ref _BrojTelefona, value); }
        }

        public string _DatumRodjenja;
        [Required]
        public string DatumRodjenja
        {
            get { return _DatumRodjenja; }
            set { SetProperty(ref _DatumRodjenja, value); }
        }

        public string _KorisnickoIme;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Korisnick oIme ne smije biti prazno!")]
        [MinLength(2, ErrorMessage = "Korisnicko Ime mora biti duže od 2 karaktera!")]
        public string KorisnickoIme
        {
            get { return _KorisnickoIme; }
            set { SetProperty(ref _KorisnickoIme, value); }
        }
        #endregion


    }
}
