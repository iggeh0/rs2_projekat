using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Smjestaj
    {
        public Smjestaj()
        {
            Ocjena = new HashSet<Ocjena>();
            OkolinaSmjestaj = new HashSet<OkolinaSmjestaj>();
            Slika = new HashSet<Slika>();
            Soba = new HashSet<Soba>();
            UslugaSmjestaj = new HashSet<UslugaSmjestaj>();
        }

        public int SmjestajId { get; set; }
        public int IzdavacId { get; set; }
        public string Naziv { get; set; }
        public double? Distanca { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public int? Zvijezde { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Izdavac Izdavac { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
        public virtual ICollection<OkolinaSmjestaj> OkolinaSmjestaj { get; set; }
        public virtual ICollection<Slika> Slika { get; set; }
        public virtual ICollection<Soba> Soba { get; set; }
        public virtual ICollection<UslugaSmjestaj> UslugaSmjestaj { get; set; }
    }
}
