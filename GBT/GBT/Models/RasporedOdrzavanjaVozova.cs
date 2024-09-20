using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
    public class RasporedOdrzavanjaVozova : BaseEntity
    {
        public DateTime DatumOdrzavanja { get; set; }
        public string Napomena { get; set; }
        [ForeignKey("VozID")]
        public Voz Voz { get; set; }
        public int VozID { get; set; }
    }
}
