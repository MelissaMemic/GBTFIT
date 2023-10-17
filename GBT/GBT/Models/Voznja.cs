using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class Voznja:BaseEntity
	{
        [ForeignKey("KrajnjaDestinacijaD")]
        public Stanica KrajnjaDestinacija { get; set; }
        public int KrajnjaDestinacijaID { get; set; }

        [ForeignKey("PocetnaDestinacijaID")]
        public Stanica PocetnaDestinacija { get; set; }
        public int PocetnaDestinacijaID { get; set; }

        public DateTime DatumVoznje { get; set; }
        public string PocetakVoznje { get; set; }
        public string KrajVoznje { get; set; }
        public string Trajanje{ get; set; }
    }
   
}

