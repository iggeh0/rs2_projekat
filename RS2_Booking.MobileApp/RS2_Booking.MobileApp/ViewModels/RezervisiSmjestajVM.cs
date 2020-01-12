using RS2_Booking.MobileApp.Views;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class RezervisiSmjestajVM : BaseViewModel
    {
        public KorisnikModel sacuvani = null;

        private readonly API_Service_Mobile service = new API_Service_Mobile("Soba");

        public RezervisiSmjestajVM()
        {
            NazadCommand = new Command(() => Nazad());
            DodajCommand = new Command<int>(Dodaj);
            KompletirajCommand = new Command(() => Kompletiraj());

        }

        SmjestajModel Smjestaj = null;

        public void UcitajSmjestaj(SmjestajModel smjestajModel)
        {
            Smjestaj = smjestajModel;
            DatumOd = DateTime.Now;
            DatumDo = DateTime.Now;
        }
        public ICommand KompletirajCommand { get; set; }

        public Task Kompletiraj()
        {
            if (Rezervacija.Sobe != null && Rezervacija.Sobe.Count > 0)
            {
                Rezervacija.SmjestajId = SmjestajId;
                Rezervacija.KlijentId = KlijentId;
                Rezervacija.DatumRezervacije = DateTime.Now;
                Rezervacija.RezervacijaDo = DatumDo;
                Rezervacija.RezervacijaOd = DatumOd;
                Rezervacija.BrojDjece = BrojDjece;
                Rezervacija.BrojOdraslih = BrojOdraslih;
                Rezervacija.Uplate = null;
                Rezervacija.StatusRezervacijeId = 1;
                Rezervacija.NazivSmjestaja = SmjestajNaziv;
                Rezervacija.AdresaSmjestaja = Adresa + ", " + GradNaziv;
            }
            else
                return null;
            IsBusy = true;
           Application.Current.MainPage = new PotvrdiRezervaciju(Rezervacija, Smjestaj, sacuvani);
            return null;
        }

        public void Dodaj(int SobaId)
        {
            if (Rezervacija.Sobe != null)
            {
                foreach (SobaModel s in Rezervacija.Sobe)
                {
                    if (s.SobaId == SobaId)
                    {
                        Application.Current.MainPage.DisplayAlert("Greška", "Soba je već dodana", "Ok");
                        return;
                    }
                }
            }
            else
            {
                Rezervacija.Sobe = new List<SobaModel>();
            }
            SobaModel OdabranaSoba = ListaSoba.Where(x => x.SobaId == SobaId).FirstOrDefault();
            Rezervacija.Sobe.Add(OdabranaSoba);
        }

        public ICommand DodajCommand { get; set; }

        #region Model

        public int _SmjestajId = 0;
        public int SmjestajId
        {
            get { return _SmjestajId; }
            set { SetProperty(ref _SmjestajId, value); }
        }

        public string _SmjestajNaziv;
        public string SmjestajNaziv
        {
            get { return _SmjestajNaziv; }
            set { SetProperty(ref _SmjestajNaziv, value); }
        }

        public string _GradNaziv;
        public string GradNaziv
        {
            get { return _GradNaziv; }
            set { SetProperty(ref _GradNaziv, value); }
        }

        public string _Adresa;
        public string Adresa
        {
            get { return _Adresa; }
            set { SetProperty(ref _Adresa, value); }
        }

        public int _KlijentId = 0;
        public int KlijentId
        {
            get { return _KlijentId; }
            set { SetProperty(ref _KlijentId, value); }
        }

        public DateTime _DatumOd;

        public DateTime DatumOd
        {
            get { return _DatumOd; }
            set { SetProperty(ref _DatumOd, value); }
        }

        public DateTime _DatumDo;

        public DateTime DatumDo
        {
            get { return _DatumDo; }
            set { SetProperty(ref _DatumDo, value); }
        }

        public int _BrojDjece = 0;
        public int BrojDjece
        {
            get { return _BrojDjece; }
            set { SetProperty(ref _BrojDjece, value); }
        }
        public int _BrojOdraslih = 0;
        public int BrojOdraslih
        {
            get { return _BrojOdraslih; }
            set { SetProperty(ref _BrojOdraslih, value); }
        }

        public int _BrojSoba = 0;
        public int BrojSoba
        {
            get { return _BrojSoba; }
            set { SetProperty(ref _BrojSoba, value); }
        }

        public ObservableCollection<SobaModel> ListaSoba { get; set; } = new ObservableCollection<SobaModel>();
        public RezervacijaModel Rezervacija { get; set; } = new RezervacijaModel();
        #endregion

        #region NazadCommand
        public ICommand NazadCommand { get; set; }

        public void Nazad()
        {
            Application.Current.MainPage = new SmjestajViewPage(SmjestajId, sacuvani);
        }
        #endregion

        public async Task SearchSmjestaj()
        {
            ListaSoba.Clear();
            SobaSearchRequest request = new SobaSearchRequest
            {
                SmjestajId = SmjestajId,
                BrojDjece = BrojDjece,
                BrojOdraslih = BrojOdraslih,
                BrojSoba = BrojSoba,
                DatumDo = DatumDo,
                DatumOd = DatumOd
            };

            List<SobaModel> PronadjeniLista = await service.Get<List<SobaModel>>(request);
            if (PronadjeniLista.Count > 0)
            {
                foreach (SobaModel s in PronadjeniLista)
                {
                    ListaSoba.Add(s);
                }
            }
            else
            {
                SobaModel prazan = new SobaModel
                {
                    SobaId = 0,
                    VrstaSmjestaja = "Nisu pronađene sobe po vašim kriterijumima"
                };
                ListaSoba.Add(prazan);
            }
             
        }
    }  
    
}
