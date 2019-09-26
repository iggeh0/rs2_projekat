using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class SobaModel
    {
        public int SobaId { get; set; }
        public int SmjestajId { get; set; }
        public int BrojKreveta { get; set; }
        public double Cijena { get; set; }
        public string VrstaSmjestaja { get; set; }
        public string Opis { get; set; }
        public int VelicinaSobe { get; set; }
        public bool VlastitaKupoanica { get; set; }
    }
}
