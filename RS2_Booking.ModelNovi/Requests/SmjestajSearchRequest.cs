using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class SmjestajSearchRequest
    {
        public int? GradId { get; set; }
        public string Naziv { get; set; }
        public int IzdavacId { get; set; }

        public int SmjestajId { get; set; }
    }
}
