using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class Voz:BaseEntity
	{
        public string Naziv { get; set; }
        public string BrojSjedista { get; set; }
        public string Boja { get; set; }
        public string DatumServisiranja { get; set; }
    }
}

