using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Slika
    {
        public int SlikaId { get; set; }
        public byte[] SlikaFile { get; set; }
        public int SmjestajId { get; set; }

        public virtual Smjestaj Smjestaj { get; set; }
    }
}
