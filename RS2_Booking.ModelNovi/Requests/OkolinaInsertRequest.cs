using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class OkolinaInsertRequest
    {
        public int OkolinaId { get; set; }
        public string Naziv { get; set; }
        public int SmjestajId { get; set; }
        public double Udaljenost { get; set; }
        public bool Nova { get; set; }
    }
}
