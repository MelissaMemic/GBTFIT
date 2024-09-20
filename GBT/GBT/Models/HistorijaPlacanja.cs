using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class HstorijaPlacanja : BaseEntity
    {
        public decimal Iznos { get; set; }
        public DateTime DatumPlacanja { get; set; }
        public string MetodPlacanja { get; set; }

        [ForeignKey("RezervacijaID")]
        public Karta Rezervacija { get; set; }
        public int RezervacijaID { get; set; }

        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
