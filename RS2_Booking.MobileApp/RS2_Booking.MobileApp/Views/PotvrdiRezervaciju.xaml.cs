using RS2_Booking.MobileApp.ViewModels;
using RS2_Booking.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public PotvrdiRezervacijuVM viewmodel = null;
        public SmjestajModel _returnmodel = null;
        public PotvrdiRezervaciju(RezervacijaModel model, SmjestajModel returnmodelSmjestaj, KorisnikModel returnmodelKorisnik)
        {
            InitializeComponent();
            _returnmodel = returnmodelSmjestaj;
            viewmodel = new PotvrdiRezervacijuVM
            {
                KlijentId = model.KlijentId,
                SmjestajId = model.SmjestajId,
                DatumRezervacije = model.DatumRezervacije,
                RezervacijaDo = model.RezervacijaDo,
                RezervacijaOd = model.RezervacijaOd,
                StatusRezervacijeId = 1,
                BrojDjece = model.BrojDjece,
                BrojOdraslih = model.BrojOdraslih,
                AdresaSmjestaja = model.AdresaSmjestaja,
                NazivSmjestaja = model.NazivSmjestaja,                
            };
            viewmodel.Sobe = new ObservableCollection<SobaModel>();
            foreach ( SobaModel s in model.Sobe )
            {
                viewmodel.Sobe.Add(s);
            }
            viewmodel.BrojSoba = viewmodel.Sobe.Count;
            BindingContext = viewmodel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewmodel.Ucitaj();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RezervisiSmjestajPage(viewmodel.returnKorisnik(), _returnmodel);       
        }
    }
}