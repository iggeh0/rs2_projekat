using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Izdavac = new HashSet<Izdavac>();
            Klijent = new HashSet<Klijent>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public bool? IsAdmin { get; set; }
        public string KorisnickoIme { get; set; }
        public string SifraSalt { get; set; }
        public string SifraHash { get; set; }
        public bool? Suspendovan { get; set; }

        public virtual ICollection<Izdavac> Izdavac { get; set; }
        public virtual ICollection<Klijent> Klijent { get; set; }
    }
}
