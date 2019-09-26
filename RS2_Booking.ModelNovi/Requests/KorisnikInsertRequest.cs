using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class KorisnikInsertRequest
    {
        //[Required]
        //[MinLength(4)]

        public string Ime { get; set; }

        //[Required]
        //[MinLength(4)]

        public string Prezime { get; set; }
        //[Required]
        //[MinLength(13)][MaxLength(13)]

        public string Jmbg { get; set; }

        //[Phone][Required]

        public string BrojTelefona { get; set; }

        //[Required]

        public DateTime DatumRodjenja { get; set; }

        //[Required][EmailAddress]

        public string Email { get; set; }
        public bool? IsAdmin { get; set; }

        //[Required][MinLength(4)]

        public string KorisnickoIme { get; set; }

        //[Required]
        //role = 1 klijent, role = 2 izdavac
        public int? Role { get; set; }

        //[Required][MinLength(4)]

        public string Sifra { get; set; }
    }
}
