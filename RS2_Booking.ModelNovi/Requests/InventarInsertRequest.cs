using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class InventarInsertRequest
    {
        [Required]
        public InventarModel Inventar { get; set; }
    }
}
