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
    public partial class SmjestajViewPage : ContentPage
    {
        public int _Id;
        public SmjestajVM viewmodel = null;
        public SmjestajViewPage()
        {
            InitializeComponent();
        }

        public SmjestajViewPage(int SmjestajId, KorisnikModel korisnikModel)
        {
            InitializeComponent();
            _Id = SmjestajId;
            viewmodel = new SmjestajVM
            {
                SmjestajId = SmjestajId,
                KorisnikId = korisnikModel.KorisnikId
            };
            viewmodel.sacuvani = korisnikModel;
            BindingContext = viewmodel;   
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewmodel.Ucitaj();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage(viewmodel.sacuvani);

        }
    }
}