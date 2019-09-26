using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Grad
    {
        public Grad()
        {
            Smjestaj = new HashSet<Smjestaj>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Smjestaj> Smjestaj { get; set; }
    }
}
