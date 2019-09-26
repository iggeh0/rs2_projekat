using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class RezervacijaSoba
    {
        public int RezervacijaSobaId { get; set; }
        public int RezervacijaId { get; set; }
        public int SobaId { get; set; }

        public virtual Rezervacija Rezervacija { get; set; }
        public virtual Soba Soba { get; set; }
    }
}
