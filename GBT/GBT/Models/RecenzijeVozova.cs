using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class RecenzijeVozova : BaseEntity
    {
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public DateTime DatumRecenzije { get; set; }

        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }

        [ForeignKey("VozID")]
        public Voz Voz { get; set; }
        public int VozID { get; set; }
    }
}
