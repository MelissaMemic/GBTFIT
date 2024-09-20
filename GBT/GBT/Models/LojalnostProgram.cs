using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class LojalnostProgram : BaseEntity
    {
        public int Poeni { get; set; }
        public string Nivo { get; set; }

        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
