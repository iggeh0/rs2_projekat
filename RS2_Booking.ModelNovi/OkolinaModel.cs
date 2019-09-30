using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class OkolinaModel
    {
        public int OkolinaId { get; set; }
        public string Naziv { get; set; }
        public int OkolinaSmjestajId { get; set; }
        public int SmjestajId { get; set; }
    }
}
