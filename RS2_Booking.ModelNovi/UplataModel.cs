using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class UplataModel
    {
        public int UplataId { get; set; }
        public double Iznos { get; set; }
        public DateTime DatumUplate { get; set; }
        public int RezervacijaId { get; set; }
        public int KreditnaKarticaId { get; set; }
        public string SifraUplate { get; set; }
    }
}
