using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class OcjenjivanjeZaposlenih : BaseEntity
    {
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public DateTime DatumOcenjivanja { get; set; }

        [ForeignKey("ZaposleniID")]
        public Korisnik Zaposleni { get; set; }
        public int ZaposleniID { get; set; }
    }
}
