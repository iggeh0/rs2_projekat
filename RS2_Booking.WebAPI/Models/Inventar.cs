using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Inventar
    {
        public Inventar()
        {
            InventarSoba = new HashSet<InventarSoba>();
        }

        public int InventarId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<InventarSoba> InventarSoba { get; set; }
    }
}
