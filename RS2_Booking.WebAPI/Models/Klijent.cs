using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Klijent
    {
        public Klijent()
        {
            Ocjena = new HashSet<Ocjena>();
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int KlijentId { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
