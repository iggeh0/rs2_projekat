using RS2_Booking.MobileApp.ViewModels;
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
        public RezervisiSmjestajPage(int KorisnikId, int SmjestajId)
        {
            InitializeComponent();
            viewmodel = new RezervisiSmjestajVM
            {
                SmjestajId = SmjestajId,
                KlijentId = KorisnikId
            };
            BindingContext = viewmodel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewmodel.Ucitavanje();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var obj = this.FindByName<FlexLayout>("NekiId");
            if (obj.IsVisible)
            {
                obj.IsVisible = false;
            }
            else
                obj.IsVisible = true;
            
        }
    }
}