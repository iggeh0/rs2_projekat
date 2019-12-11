using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class RezervacijaModel
    {
        public int StatusRezervacijeId { get; set; }
        //1 - Na obradi
        //2 - Aktivna
        //3 - Otkazao klijent
        //4 - Otkazao izdavač
        //1002 - Završena
    }
}
