using RS2_Booking.MobileApp.ViewModels;
using RS2_Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS2_Booking.MobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		RegisterVM viewmodel = null;
		KorisnikModel korisnikModel = null;
		public RegisterPage()
		{
			InitializeComponent();
		}

		public RegisterPage(KorisnikModel k)
		{
			InitializeComponent();
			viewmodel = new RegisterVM
			{
				Ime = k.Ime,
				Prezime = k.Prezime,
				BrojTelefona = k.BrojTelefona,
				DatumRodjenja = k.DatumRodjenja,
				Email = k.Email,
				JMBG = k.Jmbg,
				KorisnickoIme = k.KorisnickoIme,
				Postojeci = true
			};
			BindingContext = viewmodel;
			korisnikModel = k;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			if (viewmodel == null || !viewmodel.Postojeci)
			{
				Application.Current.MainPage = new LoginPage();
			}
			else
				Application.Current.MainPage = new MainPage(korisnikModel);
		}
	}
}