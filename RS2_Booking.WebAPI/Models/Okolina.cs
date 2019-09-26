using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Okolina
    {
        public Okolina()
        {
            OkolinaSmjestaj = new HashSet<OkolinaSmjestaj>();
        }

        public int OkolinaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<OkolinaSmjestaj> OkolinaSmjestaj { get; set; }
    }
}
