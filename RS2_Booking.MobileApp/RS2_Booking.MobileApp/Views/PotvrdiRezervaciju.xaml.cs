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
    public partial class PotvrdiRezervaciju : ContentPage
    {
        PotvrdiRezervacijuVM viewmodel = null;
        public PotvrdiRezervaciju(RezervacijaModel model)
        {
            InitializeComponent();

            viewmodel = new PotvrdiRezervacijuVM
            {
                KlijentId = model.KlijentId,
                SmjestajId = model.SmjestajId,
                DatumRezervacije = model.DatumRezervacije,
                RezervacijaDo = model.RezervacijaDo,
                RezervacijaOd = model.RezervacijaOd,
                StatusRezervacijeId = 1,
                BrojDjece = model.BrojDjece,
                BrojOdraslih = model.BrojOdraslih
            };
            viewmodel.Sobe = new List<SobaModel>();
            foreach ( SobaModel s in model.Sobe )
            {
                viewmodel.Sobe.Add(s);
            }
            BindingContext = viewmodel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewmodel.Ucitaj();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RezervisiSmjestajPage(viewmodel.KlijentId, viewmodel.SmjestajId);
        }
    }
}