using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        public int KlijentId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime RezervacijaOd { get; set; }
        public DateTime RezervacijaDo { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public int StatusRezervacijeId { get; set; }
        public List<SobaModel> Sobe { get; set; }
        public string NazivSmjestaja { get; set; }
        public string AdresaSmjestaja { get; set; }
    }
}
