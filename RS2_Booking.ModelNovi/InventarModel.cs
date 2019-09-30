using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class InventarModel
    {
        public int InventarId { get; set; }
        public string Naziv { get; set; }
        public int SobaId { get; set; }
        public int InventarSobaId { get; set; }
    }
}
