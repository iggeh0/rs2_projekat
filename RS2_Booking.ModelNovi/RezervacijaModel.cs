using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.Model
{
    public class RezervacijaModel
    {
        public int StatusRezervacijeId { get; set; }
        public string StatusRezervacijeNaziv { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime RezervacijaOd { get; set; }
        public DateTime RezervacijaDo { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public int KlijentId { get; set; }
        public string ImeKlijenta { get; set; }
        public string PrezimeKlijenta { get; set; }
        public string KorisnickoImeKlijenta { get; set; }
        public int SmjestajId { get; set; }
        public string NazivSmjestaja { get; set; }
        public string AdresaSmjestaja { get; set; }
        public List<SobaModel> Sobe { get; set; }
        public List<UplataModel> Uplate { get; set; }


        //1 - Na obradi
        //2 - Aktivna
        //3 - Otkazao klijent
        //4 - Otkazao izdavač
        //1002 - Završena
    }
}
