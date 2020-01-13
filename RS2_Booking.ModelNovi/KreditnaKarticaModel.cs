using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class KreditnaKarticaModel
    {
        public int KreditnaKarticaId { get; set; }
        public string TipKartice { get; set; }
        public string BrojKartice { get; set; }
        public int MjesecIsteka { get; set; }
        public int GodinaIsteka { get; set; }
    }
}
