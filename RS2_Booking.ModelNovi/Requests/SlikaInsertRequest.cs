using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class SlikaInsertRequest
    {
        public int SmjestajId { get; set; }
        public byte[]  SlikaFile { get; set; }
    }
}
