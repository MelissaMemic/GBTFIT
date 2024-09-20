namespace GBT.Models
{
    public class VremenskaPrognoza : BaseEntity
    {
        public string Grad { get; set; }
        public DateTime Datum { get; set; }
        public string Prognoza { get; set; }
    }
}
