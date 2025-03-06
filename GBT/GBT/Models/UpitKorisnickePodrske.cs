using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class UpitiKorisnickePodrske : BaseEntity
    {
        public string Sadrzaj { get; set; }
        public DateTime DatumUpita { get; set; }
        public string Status { get; set; }

        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
        public string? ImagePath { get; set; } 

    }
}
