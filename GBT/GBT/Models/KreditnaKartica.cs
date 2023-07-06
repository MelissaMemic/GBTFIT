using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class KreditnaKartica:BaseEntity
	{
		[ForeignKey("KorisnikID")]
		public Korisnik Korisnik { get; set; }
		public int KorisnikID { get; set; }
		public string BrojKartice { get; set; }
		public int Code { get; set; }

	}
}

