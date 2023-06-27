using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class Stanica:BaseEntity
	{
        public string Naziv { get; set; }

        [ForeignKey("GradID")]
        public Grad Grad { get; set; }
        public int GradID { get; set; }
    }
}

