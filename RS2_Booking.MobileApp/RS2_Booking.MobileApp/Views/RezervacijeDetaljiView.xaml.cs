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
    public partial class RezervacijeDetaljiView : ContentPage
    {
        RezervacijaDetaljiVM model = null;
        KorisnikModel _sacuvani = null;
        public RezervacijeDetaljiView(int RezervacijaId, KorisnikModel Sacuvani)
        {
            InitializeComponent();
            _sacuvani = Sacuvani;
            model = new RezervacijaDetaljiVM();
            model.RezervacijaId = RezervacijaId;
            BindingContext = model;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Ucitaj();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage(_sacuvani);
        }
    }
}