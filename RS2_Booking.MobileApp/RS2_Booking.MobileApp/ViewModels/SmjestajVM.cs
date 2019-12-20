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

        int _SmjestajId;

        SmjestajModel Model;

        public SmjestajVM(int Id)
        {
            _SmjestajId = Id;
            UcitajCommand = new Command(async () => await Ucitaj());

        }

        public SmjestajVM()
        {

        }

        ICommand UcitajCommand;

        async Task Ucitaj()
        {
            Model = await _smjestajService.GetById<SmjestajModel>(_SmjestajId);
        }

    }
}
