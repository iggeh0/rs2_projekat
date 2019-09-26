using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Uplata
    {
        public int UplataId { get; set; }
        public double Iznos { get; set; }
        public DateTime DatumUplate { get; set; }
        public int RezervacijaId { get; set; }
        public int KreditnaKarticaId { get; set; }
        public string SifraUplate { get; set; }

        public virtual KreditnaKartica KreditnaKartica { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
    }
}
