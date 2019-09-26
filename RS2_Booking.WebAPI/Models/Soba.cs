using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Soba
    {
        public Soba()
        {
            InventarSoba = new HashSet<InventarSoba>();
            RezervacijaSoba = new HashSet<RezervacijaSoba>();
        }

        public int SobaId { get; set; }
        public int SmjestajId { get; set; }
        public int BrojKreveta { get; set; }
        public double Cijena { get; set; }
        public string VrstaSmjestaja { get; set; }
        public string Opis { get; set; }
        public int VelicinaSobe { get; set; }
        public bool VlastitaKupoanica { get; set; }

        public virtual Smjestaj Smjestaj { get; set; }
        public virtual ICollection<InventarSoba> InventarSoba { get; set; }
        public virtual ICollection<RezervacijaSoba> RezervacijaSoba { get; set; }
    }
}
