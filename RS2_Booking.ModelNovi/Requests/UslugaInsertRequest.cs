using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class UslugaInsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int SmjestajId { get; set; }
        public int UslugaId { get; set; }
        public bool Nova { get; set; }
    }
}
