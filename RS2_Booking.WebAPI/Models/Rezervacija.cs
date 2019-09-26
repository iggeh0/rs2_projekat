using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            RezervacijaSoba = new HashSet<RezervacijaSoba>();
            Uplata = new HashSet<Uplata>();
        }

        public int RezervacijaId { get; set; }
        public int KlijentId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime RezervacijaOd { get; set; }
        public DateTime RezervacijaDo { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public int StatusRezervacijeId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual StatusRezervacije StatusRezervacije { get; set; }
        public virtual ICollection<RezervacijaSoba> RezervacijaSoba { get; set; }
        public virtual ICollection<Uplata> Uplata { get; set; }
    }
}
