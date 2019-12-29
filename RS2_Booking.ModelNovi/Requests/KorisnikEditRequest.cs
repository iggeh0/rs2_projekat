using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class KorisnikEditRequest
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public string SifraPonovo { get; set; }

        public string Response { get; set; }
    }
}
