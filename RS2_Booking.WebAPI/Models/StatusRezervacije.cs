using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class StatusRezervacije
    {
        public StatusRezervacije()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int StatusRezervacijeId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
