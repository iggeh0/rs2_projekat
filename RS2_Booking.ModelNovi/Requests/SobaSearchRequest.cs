﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class SobaSearchRequest
    {
        public int SmjestajId { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int BrojDjece { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojSoba { get; set; }


    }
}
