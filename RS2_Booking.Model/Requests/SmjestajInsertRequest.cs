using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class SmjestajInsertRequest
    {
        public int SmjestajId { get; set; }
        public int IzdavacId { get; set; }
        public string Naziv { get; set; }
        public double? Distanca { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public int GradId { get; set; }
    }
}
