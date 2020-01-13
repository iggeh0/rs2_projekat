using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class RezervacijaChangeStatusRequest
    {
        public int RezervacijaId { get; set; }
        public int StatusId { get; set; }
    }
}
