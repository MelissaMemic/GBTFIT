using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class StatusPosiljki : BaseEntity
    {
        public string Status { get; set; }
        public DateTime DatumStatusa { get; set; }

        [ForeignKey("PosiljkaID")]
        public Posiljka Posiljka { get; set; }
        public int PosiljkaID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
