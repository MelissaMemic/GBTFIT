using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class KreditnaKartica:BaseEntity
	{
		public string BrojKartice { get; set; }
		public int Code { get; set; }

		[ForeignKey("KorisnikID")]
		public Korisnik Korisnik { get; set; }
		public int KorisnikID { get; set; }
	}
}

