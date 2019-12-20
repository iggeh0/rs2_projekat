using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class PocetnaVM : BaseViewModel
    {
        private readonly API_Service_Mobile _smjestajService = new API_Service_Mobile("smjestaj");
        private readonly API_Service_Mobile _gradService = new API_Service_Mobile("grad");
        GradModel _odabraniGrad = null;

        public PocetnaVM()
        {
            UcitajCommand = new Command(async () => await Ucitaj());
        }

        public GradModel SelectedGrad
        {
            get { return _odabraniGrad; }
            set { SetProperty(ref _odabraniGrad, value);
                if (value != null)
                {
                    UcitajCommand.Execute(null);
                }
            }
        }

        public ObservableCollection<SmjestajModel> ListaSmjestaja { get; set; } = new ObservableCollection<SmjestajModel>();
        public ObservableCollection<GradModel> ListaGradova { get; set; } = new ObservableCollection<GradModel>();

        public KorisnikModel Korisnik { get; set; }

        public ICommand UcitajCommand { get; set; }


        public async Task Ucitaj()
        {
            if (ListaGradova.Count == 0)
            {
                var sourceGrad = await _gradService.Get<List<GradModel>>(null);

                ListaGradova.Clear();

                if (sourceGrad.Count > 0)
                {
                    foreach (GradModel g in sourceGrad)
                    {
                        ListaGradova.Add(g);
                    }
                }
                GradModel prazan = new GradModel
                {
                    Naziv = "Odaberite grad...",
                    GradId = 0
                };
                SelectedGrad = prazan;
                ListaGradova.Insert(0, prazan);
            }


            if (SelectedGrad != null)
            {
                var source = new List<SmjestajModel>();
                if (_odabraniGrad.GradId > 0)
                {
                    SmjestajSearchRequest request = new SmjestajSearchRequest
                    {
                        GradId = _odabraniGrad.GradId
                    };
                     source = await _smjestajService.Get<List<SmjestajModel>>(request);
                }
                else
                {
                     source = await _smjestajService.Get<List<SmjestajModel>>(null);
                }


                ListaSmjestaja.Clear();
                if (source.Count > 0)
                {
                    foreach (SmjestajModel s in source)
                    {
                        ListaSmjestaja.Add(s);
                    }
                }
                else
                {
                    SmjestajModel prazan = new SmjestajModel
                    {
                        SmjestajId = 0,
                        Naziv = "Nema unesenih smještaja u ovom gradu",
                        GradNaziv = "",
                        Zvijezde = 0
                    };
                    ListaSmjestaja.Add(prazan);
                }
            }
        }


    }
}
