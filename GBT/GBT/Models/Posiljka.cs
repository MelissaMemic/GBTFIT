using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class Posiljka:BaseEntity
	{
        [ForeignKey("StatusPosiljkeID")]
        public StatusPosiljki StatusPosiljke { get; set; }
        public int StatusPosiljkeID { get; set; }

        [ForeignKey("PosiljaocID")]
        public Korisnik Posiljaoc { get; set; }
        public int PosiljaocID { get; set; }

        [ForeignKey("PrimalacID")]
        public Korisnik Primalac { get; set; }
        public int PrimalacID { get; set; }
    }
}

