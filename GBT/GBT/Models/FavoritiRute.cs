using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class FavoritiRute : BaseEntity
    {
        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }

        [ForeignKey("RasporedVoznjiID")]
        public Voznja RasporedVoznji { get; set; }
        public int RasporedVoznjiID { get; set; }
    }
}
