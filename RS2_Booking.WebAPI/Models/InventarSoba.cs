using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class InventarSoba
    {
        public int InventarSobaId { get; set; }
        public int SobaId { get; set; }
        public int InventarId { get; set; }

        public virtual Inventar Inventar { get; set; }
        public virtual Soba Soba { get; set; }
    }
}
