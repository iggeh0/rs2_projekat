using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class IzvjestajModel
    {
        public class SmjestajDio
        {
            public string NazivSmjestaja { get; set; }
            public int BrojRezervacija { get; set; }
            public float Zarada { get; set; }
        }
        public class KorisniciDio
        {
            public string ImePrezime { get; set; }
            public string KorisnickoIme { get; set; }
            public int BrojRezervacija { get; set; }
        }
    }
}
