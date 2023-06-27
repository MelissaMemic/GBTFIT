using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class Voznja:BaseEntity
	{
        [ForeignKey("KrajnjaDestinacijaD")]
        public Stanica KrajnjaDestinacija { get; set; }
        public int KrajnjaDestinacijaD { get; set; }

        [ForeignKey("PocetnaDestinacijaID")]
        public Stanica PocetnaDestinacija { get; set; }
        public int PocetnaDestinacijaID { get; set; }

        public DateOnly DatumVoznje { get; set; }
        public string PocetakVoznje { get; set; }
        public string KrajVoznje { get; set; }
        public string Trajanje { get; set; }
        public Klasa KlasaVoznje { get; set; }
        public bool Obrok { get; set; }
        public bool Popust { get; set; }
        public int BrojPerona { get; set; }
    }
    public enum Klasa
    {
       Prva,
       Druga
    }
}

