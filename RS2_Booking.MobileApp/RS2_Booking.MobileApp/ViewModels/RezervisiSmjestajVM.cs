using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.MobileApp.ViewModels
{
    public class RezervisiSmjestajVM : BaseViewModel
    {
        #region Model

        public int _SmjestajId = 0;
        public int SmjestajId
        {
            get { return _SmjestajId; }
            set { SetProperty(ref _SmjestajId, value); }
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

        #endregion


    }
}
