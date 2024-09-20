using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class RezervacijaSedista : BaseEntity
    {
        public string BrojSjedista { get; set; }

        [ForeignKey("RezervacijaID")]
        public Karta Rezervacija { get; set; }
        public int RezervacijaID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }

        [ForeignKey("VozID")]
        public Voz Voz { get; set; }
        public int VozID { get; set; }
    }
}
