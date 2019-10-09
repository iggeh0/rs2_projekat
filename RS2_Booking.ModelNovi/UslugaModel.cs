using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class UslugaModel
    {
        public int UslugaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int UslugaSmjestajId { get; set; }
    }
}
