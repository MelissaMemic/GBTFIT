using System.ComponentModel.DataAnnotations;

namespace GBT.Models
{
    public class PromocijePopusti : BaseEntity
    {
        public string Naziv { get; set; }
        public decimal ProcenatPopusta { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
    }
}
