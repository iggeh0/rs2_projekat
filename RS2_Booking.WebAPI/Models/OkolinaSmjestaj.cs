using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class OkolinaSmjestaj
    {
        public int OkolinaSmjestajId { get; set; }
        public int OkolinaId { get; set; }
        public int SmjestajId { get; set; }
        public double Udaljenost { get; set; }

        public virtual Okolina Okolina { get; set; }
        public virtual Smjestaj Smjestaj { get; set; }
    }
}
