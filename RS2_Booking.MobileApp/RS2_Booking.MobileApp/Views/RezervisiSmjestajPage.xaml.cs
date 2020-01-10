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
    public partial class RezervisiSmjestajPage : ContentPage
    {
        public RezervisiSmjestajVM viewmodel = null;
        public RezervisiSmjestajPage(int KorisnikId, SmjestajModel Smjestaj)
        {
            InitializeComponent();
            viewmodel = new RezervisiSmjestajVM
            {
                SmjestajId = Smjestaj.SmjestajId,
                KlijentId = KorisnikId,
                SmjestajNaziv = Smjestaj.Naziv,
                GradNaziv = Smjestaj.GradNaziv,
                Adresa = Smjestaj.Adresa
            };       
            BindingContext = viewmodel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var obj = this.FindByName<StackLayout>("NekiId");
            obj.IsVisible = true;
            await viewmodel.SearchSmjestaj();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            int id = (int)obj.CommandParameter;
            viewmodel.Dodaj(id);
        }
    }
}