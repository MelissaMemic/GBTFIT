using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using GBT.Models;
using GBT.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;

namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class KartaController : Controller
    {

        private readonly MojDBContext _dbContext;
        public KartaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<Karta> GetKarte()
        {
            return Ok(_dbContext.Karta.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<List<Karta>> GetByKorisnikId(int id)
        {
            var karteKorisnika = _dbContext.Karta.Where(k => k.KorisnikID == id).ToList();
            if (karteKorisnika.Any())
            {
                return Ok(karteKorisnika);
            }
            return NotFound(); 


        }
        [HttpGet("past-bookings")]
        public ActionResult<List<Karta>> GetPastBookings(int korisnikID)
        {
            var now = DateTime.UtcNow;
            var pastBookings = _dbContext.Karta
                .Where(k => k.KorisnikID == korisnikID && k.Voznja.DatumVoznje < now)
                .Select(k => new {
                    k.ID,
                    Date = k.Voznja.DatumVoznje.ToString("yyyy-MM-dd"),
                    Destination = k.Voznja.KrajnjaDestinacijaID,
                    Class = k.KlasaVoznje,
                    Meal = k.Obrok,
                    Discount = k.Popust,
                    PlatformNumber = k.BrojPerona,
                    Price = k.Cijena,
                    Paid = k.isPlaceno
                })
                .ToList();

            return Ok(pastBookings);
        }

        [HttpGet("upcoming-reservations")]
        public ActionResult<List<Karta>> GetUpcomingReservations(int korisnikID)
        {
            var now = DateTime.UtcNow;
            var upcomingReservations = _dbContext.Karta
                .Where(k => k.KorisnikID == korisnikID && k.Voznja.DatumVoznje >= now)
                .Select(k => new {
                    k.ID,
                    Date = k.Voznja.DatumVoznje.ToString("yyyy-MM-dd"),
                    Destination = k.Voznja.KrajnjaDestinacijaID,
                    Class = k.KlasaVoznje,
                    Meal = k.Obrok,
                    Discount = k.Popust,
                    PlatformNumber = k.BrojPerona,
                    Price = k.Cijena,
                    Paid = k.isPlaceno
                })
                .ToList();

            return Ok(upcomingReservations);
        }


        [HttpPost]
        public ActionResult Snimi([FromBody] KartaSnimiVM x)
        {
            Karta? novaKarta;
            if (x.ID == 0)
            {
                novaKarta = new Karta
                {
                    KorisnikID = x.KorisnikID,
                    VoznjaID = x.PocetnaDestinacijaID, 
                    BrojPerona = x.BrojPerona,
                    KlasaVoznje = x.KlasaVoznje,
                    Obrok = x.Obrok,
                    Popust = x.Popust,
                    Cijena = x.Cijena
                };

                if (x.Popust)
                {
                    novaKarta.Cijena -= 3;
                }

                _dbContext.Add(novaKarta);
                _dbContext.SaveChanges(); 
            }
            else
            {
                return BadRequest("pogresan ID");
            }


            return Ok(novaKarta);
        }

    }
}

