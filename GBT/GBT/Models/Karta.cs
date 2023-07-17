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

        public Klasa KlasaVoznje { get; set; }
        public bool Obrok { get; set; }
        public bool Popust { get; set; }
        public int BrojPerona { get; set; }

        public double? Cijena { get; set; }
        public bool isPlaceno { get; set; }
    }
    public enum Klasa
    {
        Prva,
        Druga
    }
}

