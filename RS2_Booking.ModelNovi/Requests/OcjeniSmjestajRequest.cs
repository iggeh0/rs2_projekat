using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class OcjeniSmjestajRequest
    {
        public int Ocjena { get; set; }
        public int KlijentId { get; set; }
        public int SmjestajId { get; set; }

        public string Komentar { get; set; }
    }
}
