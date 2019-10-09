using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class SobaInsertRequest
    {
        public int SmjestajId { get; set; }
        public int BrojKreveta { get; set; }
        public double Cijena { get; set; }
        public string VrstaSmjestaja { get; set; }
        public string Opis { get; set; }
        public int VelicinaSobe { get; set; }
        public bool VlastitaKupoanica { get; set; }
        public int SobaId { get; set; }
    }
}
