using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Izdavac
    {
        public Izdavac()
        {
            Smjestaj = new HashSet<Smjestaj>();
        }

        public int IzdavacId { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Smjestaj> Smjestaj { get; set; }
    }
}
