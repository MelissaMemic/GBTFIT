using System.Collections.Generic;
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

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<List<Karta>> GetByKorisnikId(int id)
        {
            var karteKorisnika = _dbContext.Karta.Where(k => k.KorisnikID == id).ToList();
            if (karteKorisnika.Any())
            {
                return Ok(karteKorisnika);
            }
            return NotFound(); // Return 404 if the resource with the specified ID is not found


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
                    VoznjaID = x.ID,
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
            }
            else
            {
                return BadRequest("pogresan ID");
            }
           
            return Ok(novaKarta);
        }
    }
}

