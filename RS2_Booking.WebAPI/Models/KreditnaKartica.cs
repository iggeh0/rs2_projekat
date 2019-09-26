using System;
using System.Collections.Generic;

namespace RS2_Booking.WebAPI.Models
{
    public partial class KreditnaKartica
    {
        public KreditnaKartica()
        {
            Uplata = new HashSet<Uplata>();
        }

        public int KreditnaKarticaId { get; set; }
        public string TipKartice { get; set; }
        public string BrojKartice { get; set; }
        public int MjesecIsteka { get; set; }
        public int GodinaIsteka { get; set; }

        public virtual ICollection<Uplata> Uplata { get; set; }
    }
}
