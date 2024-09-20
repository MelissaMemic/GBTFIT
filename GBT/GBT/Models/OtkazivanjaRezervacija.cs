using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class OtkazivanjaRezervacija : BaseEntity
    {
        public DateTime DatumOtkazivanja { get; set; }
        public string Razlog { get; set; }

        [ForeignKey("RezervacijaID")]
        public Voznja Rezervacija { get; set; }
        public int RezervacijaID { get; set; }

        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
