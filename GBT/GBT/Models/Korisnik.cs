using System.ComponentModel.DataAnnotations;

namespace GBT.Models
{
    public class Korisnik:BaseEntity
    {
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Token { get; set; }
    public string Rola { get; set; }
    public string Email { get; set; }
  }
}
