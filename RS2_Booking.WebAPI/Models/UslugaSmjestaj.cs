using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class UslugaSmjestaj
    {
        public int UslugaSmjestajId { get; set; }
        public int SmjestajId { get; set; }
        public int UslugaId { get; set; }

        public virtual Smjestaj Smjestaj { get; set; }
        public virtual Usluga Usluga { get; set; }
    }
}
