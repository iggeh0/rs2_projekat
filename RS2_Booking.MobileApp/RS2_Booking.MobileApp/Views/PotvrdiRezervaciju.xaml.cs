using RS2_Booking.MobileApp.ViewModels;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
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
        public PotvrdiRezervaciju(RezervacijaInsertRequest model, SmjestajModel returnmodelSmjestaj, KorisnikModel returnmodelKorisnik)
        {
            InitializeComponent();
            _returnmodel = returnmodelSmjestaj;
            viewmodel = new PotvrdiRezervacijuVM
            {
                KlijentId = model.KlijentId,
                DatumRezervacije = model.DatumRezervacije,
                RezervacijaDo = model.RezervacijaDo,
                RezervacijaOd = model.RezervacijaOd,
                StatusRezervacijeId = 1,
                BrojDjece = model.BrojDjece,
                BrojOdraslih = model.BrojOdraslih,
                NazivSmjestaja = model.NazivSmjestaja,
                AdresaSmjestaja = model.AdresaSmjestaja
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