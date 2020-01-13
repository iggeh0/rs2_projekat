using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class UplataInsertRequest
    {
        public int RezervacijaId { get; set; }
        public double Iznos { get; set; }

        public DateTime DatumUplate { get; set; }
        public int KreditnaKarticaId { get; set; }
        public string SifraUplate { get; set; }

       public virtual KreditnaKarticaModel KreditnaKartica { get; set; }

    }
}
