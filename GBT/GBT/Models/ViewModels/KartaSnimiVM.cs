namespace GBT.Models.ViewModels
{
	public class KartaSnimiVM:BaseEntity
	{
		public int KorisnikID { get; set; }

        public int KrajnjaDestinacijaID { get; set; }
        public int PocetnaDestinacijaID { get; set; }
        public DateOnly DatumVoznje { get; set; }
        public string PocetakVoznje { get; set; }
        public string KrajVoznje { get; set; }
        public string Trajanje { get; set; }
        public Klasa KlasaVoznje { get; set; }
        public bool Obrok { get; set; }
        public bool Popust { get; set; }
        public int BrojPerona { get; set; }
        public double Cijena { get; set; }
    }
}

