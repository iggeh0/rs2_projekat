using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class RezervacijaModelShort
    {
        public int StatusRezervacijeId { get; set; }
        public DateTime RezervacijaOd { get; set; }
        public DateTime RezervacijaDo { get; set; }
        public int KlijentId { get; set; }
    }
}
