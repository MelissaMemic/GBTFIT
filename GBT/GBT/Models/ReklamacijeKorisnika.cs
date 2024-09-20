using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class ReklamacijeKorisnika : BaseEntity
    {
        public string Opis { get; set; }
        public DateTime DatumReklamacije { get; set; }
        public bool Reseno { get; set; }

        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
