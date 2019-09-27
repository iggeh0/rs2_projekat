using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class InventarSearchRequest
    {
        public int InventarId { get; set; }
        [Required(AllowEmptyStrings =false)]
        public int SobaId { get; set; }
    }
}
