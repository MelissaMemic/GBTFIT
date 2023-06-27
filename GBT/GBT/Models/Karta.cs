using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class Karta:BaseEntity
	{
        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }

        [ForeignKey("VoznjaID")]
        public Voznja Voznja { get; set; }
        public int VoznjaID { get; set; }

        public int Cijena { get; set; }
    }
}

