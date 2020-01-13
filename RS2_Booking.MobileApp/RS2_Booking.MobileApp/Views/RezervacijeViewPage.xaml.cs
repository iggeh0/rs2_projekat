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
    public partial class RezervacijeViewPage : ContentPage
    {
        public RezervacijeVM viewmodel = null;
        public RezervacijeViewPage(KorisnikModel k)
        {
            InitializeComponent();            
            viewmodel = new RezervacijeVM();
            viewmodel.sacuvani = k;
            BindingContext = viewmodel;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewmodel.Ucitaj();
        }

        private void RezervacijaDetalji(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            int id = (int)obj.CommandParameter;
            Application.Current.MainPage = new RezervacijeDetaljiView(id, viewmodel.sacuvani);
        }
    }
}