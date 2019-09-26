using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int Iznos { get; set; }
        public int KlijentId { get; set; }
        public int SmjestajId { get; set; }
        public string Komentar { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Smjestaj Smjestaj { get; set; }
    }
}
