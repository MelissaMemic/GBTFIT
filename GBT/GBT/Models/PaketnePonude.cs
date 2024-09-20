using System.ComponentModel.DataAnnotations;

namespace GBT.Models
{
    public class PaketnePonude : BaseEntity
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int Popust { get; set; }
    }
}
