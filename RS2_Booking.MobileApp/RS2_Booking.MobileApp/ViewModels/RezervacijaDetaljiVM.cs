using RS2_Booking.Model;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Text;using System.Threading.Tasks;using System.Windows.Input;using Xamarin.Forms;using RS2_Booking.Model.Requests;namespace RS2_Booking.MobileApp.ViewModels{    public class RezervacijaDetaljiVM : BaseViewModel    {        private readonly API_Service_Mobile _smjestajService = new API_Service_Mobile("rezervacija");
        private readonly API_Service_Mobile _otkaziService = new API_Service_Mobile("rezervacija/promjenistatus");
        private readonly API_Service_Mobile _ocjenaService = new API_Service_Mobile("smjestaj/ocjenismjestaj");
        public RezervacijaDetaljiVM()        {            OtkaziCommand = new Command(async () => await Otkazi());
            OcjeniCommand = new Command(async () => await Ocjeni());        }        public ICommand OtkaziCommand { get; set; }        public async Task Otkazi()        {
            RezervacijaChangeStatusRequest request = new RezervacijaChangeStatusRequest();
            request.RezervacijaId = RezervacijaId;
            request.StatusId = 3;
            IsBusy = true;
            await _otkaziService.Insert<RezervacijaChangeStatusRequest>(request);
            StatusRezervacijeId = 2;
            StatusRezervacijeNaziv = "Otkazano od strane klijenta";
            Aktivna = false;
        }

        public ICommand OcjeniCommand { get; set; }        public async Task Ocjeni()
        {
            if (OdabranaOcjena > 0)
            {
                OcjeniSmjestajRequest request = new OcjeniSmjestajRequest();
                request.SmjestajId = SmjestajId;
                request.KlijentId = KlijentId;
                request.Ocjena = OdabranaOcjena;
               await _ocjenaService.Insert<OcjeniSmjestajRequest>(request);
            }

        }        public async Task Ucitaj()        {            if (Ocjene.Count == 0)
            {
                List<int> OcjeneList = new List<int>();
                Ocjene.Add(1);
                Ocjene.Add(2);
                Ocjene.Add(3);
                Ocjene.Add(4);
                Ocjene.Add(5);
            }            RezervacijaModel model = await _smjestajService.GetById<RezervacijaModel>(RezervacijaId);            AdresaSmjestaja = model.AdresaSmjestaja;            BrojDjece = model.BrojDjece;            BrojOdraslih = model.BrojOdraslih;            DatumRezervacijeShort = model.DatumRezervacijeShort;            NazivSmjestaja = model.NazivSmjestaja;            RezervacijaDoShort = model.RezervacijaDoShort;            RezervacijaOdShort = model.RezervacijaOdShort;            StatusRezervacijeId = model.StatusRezervacijeId;            StatusRezervacijeNaziv = model.StatusRezervacijeNaziv;            SmjestajId = model.SmjestajId;            KlijentId = model.KlijentId;            if (StatusRezervacijeId == 1)
                Aktivna = true;                      else                Aktivna = false;            DateTime Pocetni = Convert.ToDateTime(RezervacijaOdShort);            DateTime Krajnji = Convert.ToDateTime(RezervacijaDoShort);            int Dani = (Krajnji - Pocetni).Days;            UkupnaCijena = new double();            foreach ( SobaModel S in model.Sobe )            {                Sobe.Add(S);                UkupnaCijena += S.Cijena * Dani;                          }
            UkupnoUplaceno = new double();            if ( model.Uplate != null && model.Uplate.Count > 0 )            {                              foreach ( UplataModel u in model.Uplate )                {                    Uplate.Add(u);                    UkupnoUplaceno += u.Iznos;                }            }        }        #region model        public int _RezervacijaId;        public int RezervacijaId        {            get { return _RezervacijaId; }            set { SetProperty(ref _RezervacijaId, value); }        }        public int _StatusRezervacijeId;        public int StatusRezervacijeId        {            get { return _StatusRezervacijeId; }            set { SetProperty(ref _StatusRezervacijeId, value); }        }        public string _StatusRezervacijeNaziv;        public string StatusRezervacijeNaziv        {            get { return _StatusRezervacijeNaziv; }            set { SetProperty(ref _StatusRezervacijeNaziv, value); }        }

        public string _Komentar;        public string Komentar        {            get { return _Komentar; }            set { SetProperty(ref _Komentar, value); }        }

        public bool _Aktivna;        public bool Aktivna        {            get { return _Aktivna; }            set { SetProperty(ref _Aktivna, value); }        }        public string _DatumRezervacijeShort;         public string DatumRezervacijeShort        {            get { return _DatumRezervacijeShort; }            set { SetProperty(ref _DatumRezervacijeShort, value); }        }        public string _RezervacijaOdShort;        public string RezervacijaOdShort        {            get { return _RezervacijaOdShort; }            set { SetProperty(ref _RezervacijaOdShort, value); }        }        public string _RezervacijaDoShort;        public string RezervacijaDoShort        {            get { return _RezervacijaDoShort; }            set { SetProperty(ref _RezervacijaDoShort, value); }        }        public int _BrojOdraslih;        public int BrojOdraslih        {            get { return _BrojOdraslih; ; }            set { SetProperty(ref _BrojOdraslih, value); }        }        public int _BrojDjece;        public int BrojDjece        {            get { return _BrojDjece; ; }            set { SetProperty(ref _BrojDjece, value); }        }        public int _KlijentId;        public int KlijentId        {            get { return _KlijentId; ; }            set { SetProperty(ref _KlijentId, value); }        }        public int _SmjestajId;        public int SmjestajId        {            get { return _SmjestajId; ; }            set { SetProperty(ref _SmjestajId, value); }        }

        public int _OdabranaOcjena;        public int OdabranaOcjena        {            get { return _OdabranaOcjena; ; }            set { SetProperty(ref _OdabranaOcjena, value); }        }        public string _NazivSmjestaja;        public string NazivSmjestaja        {            get { return _NazivSmjestaja; ; }            set { SetProperty(ref _NazivSmjestaja, value); }        }        public string _AdresaSmjestaja;        public string AdresaSmjestaja        {            get { return _AdresaSmjestaja; ; }            set { SetProperty(ref _AdresaSmjestaja, value); }        }        public ObservableCollection<SobaModel> Sobe { get; set; } = new ObservableCollection<SobaModel>();        public ObservableCollection<UplataModel> Uplate { get; set; } = new ObservableCollection<UplataModel>();        public ObservableCollection<int> Ocjene { get; set; } = new ObservableCollection<int>();        public double _UkupnaCijena = 0;        public double UkupnaCijena        {            get { return _UkupnaCijena; ; }            set { SetProperty(ref _UkupnaCijena, value); }        }          public double _UkupnoUplaceno = 0;        public double UkupnoUplaceno        {            get { return _UkupnoUplaceno; ; }            set { SetProperty(ref _UkupnoUplaceno, value); }        }        #endregion    }}