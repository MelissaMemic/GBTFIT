using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class Grad:BaseEntity
    {


        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }

        [ForeignKey("DrzavaID")]
        public Drzava Drzava { get; set; }
        public int DrzavaID { get; set; }
    }
}
