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
    public class LoginVM : BaseViewModel
    {
        private readonly API_Service_Mobile service = new API_Service_Mobile("korisnik/Login");
        public LoginVM()
        {
            LoginCommand = new Command(async () => await Login());
        }

        public string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            API_Service_Mobile.Username = Username;
            API_Service_Mobile.Password = Password;
            try
            {
                LoginRequest request = new LoginRequest
                {
                    KorisnickoIme = Username,
                    Lozinka = Password,
                    Uloga = 2
                };
                KorisnikModel k = await service.Get<KorisnikModel>(request);

                if (k.OK)
                {
                    Application.Current.MainPage = new MainPage();
                }

            }
            catch(Exception ex)
            {

            }
        }
    }
}
