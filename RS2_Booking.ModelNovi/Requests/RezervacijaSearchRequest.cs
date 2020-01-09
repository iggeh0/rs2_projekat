using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class RezervacijaSearchRequest
    {
        public int KlijentId { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int StatusRezervacijeId { get; set; }

    }
}
