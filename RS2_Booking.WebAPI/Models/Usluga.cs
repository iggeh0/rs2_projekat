using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Usluga
    {
        public Usluga()
        {
            UslugaSmjestaj = new HashSet<UslugaSmjestaj>();
        }

        public int UslugaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<UslugaSmjestaj> UslugaSmjestaj { get; set; }
    }
}
