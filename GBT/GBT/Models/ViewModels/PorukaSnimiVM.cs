using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models.ViewModels
{
	public class PorukaSnimiVM
	{
        public int ID { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumUpita { get; set; }
        public string Status { get; set; }
        public int KorisnikID { get; set; }
    }
}

