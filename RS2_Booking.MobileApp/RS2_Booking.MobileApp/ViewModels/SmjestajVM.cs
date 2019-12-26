using RS2_Booking.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class SmjestajVM : BaseViewModel
    {

        private readonly API_Service_Mobile _smjestajService = new API_Service_Mobile("smjestaj");
        private readonly API_Service_Mobile _korisnikService = new API_Service_Mobile("korisnik");

        public int _SmjestajId = 0;


        #region Model
        public int SmjestajId
        {
            get { return _SmjestajId; }
            set { SetProperty(ref _SmjestajId, value); }
        }

        public int IzdavacId { get; set; }
        public string Naziv { get; set; }
        public double? Distanca { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public int? Zvijezde { get; set; }
        public string GradNaziv { get; set; }

        #endregion

        public SmjestajVM()
        {
            UcitajCommand = new Command(async () => await Ucitaj());

        }

        public ICommand UcitajCommand { get; set; }

        public async Task Ucitaj()
        {
            SmjestajModel Model = await _smjestajService.GetById<SmjestajModel>(_SmjestajId);
        }

    }
}
