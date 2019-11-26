using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class LoginRequest
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int Uloga { get; set; }
    }
}
