using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class InventarInsertRequest
    {
        public int InventarId { get; set; }
        public string Naziv { get; set; }
        public int SobaId { get; set; }
        public int InventarSobaId { get; set; }
    }
}
