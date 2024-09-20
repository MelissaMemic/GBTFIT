using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class ObavestenjaKorisnicima : BaseEntity
    {
        public string Poruka { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool Procitano { get; set; }

        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
