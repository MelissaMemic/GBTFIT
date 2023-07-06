using GBT.Models;
using GBT.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;

namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class KreditnaKarticaController : Controller
    {
        private readonly MojDBContext _dbContext;
        public KreditnaKarticaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<KreditnaKartica> GetKreditnaKartica()
        {
            return Ok(_dbContext.KreditnaKartica.ToList());
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<List<KreditnaKartica>> GetKreditnaKarticaByKorisnikId(int id)
        {
            var kreditnaKartica = _dbContext.KreditnaKartica.Where(k => k.KorisnikID == id).ToList();
            if (kreditnaKartica.Any())
            {
                return Ok(kreditnaKartica);
            }
            return NotFound(); // Return 404 if the resource with the specified ID is not found
        }

        [HttpPost]
        public ActionResult Snimi([FromBody] KreditnaKarticaSnimiVM x)
        {
            KreditnaKartica? novaKarta;
            if (x.ID == 0)
            {
                novaKarta = new KreditnaKartica();
                novaKarta.DateCreated = DateTime.Now;
                _dbContext.Add(novaKarta);
            }
            else
            {
                novaKarta = _dbContext.KreditnaKartica.Find(x.ID);
            }
            if (novaKarta == null)
                return BadRequest("pogresan ID");

            novaKarta.BrojKartice = x.BrojKartice;
            novaKarta.Code = x.Code;
            novaKarta.KorisnikID = x.KorisnikID;
            novaKarta.DateModified = DateTime.Now;

            _dbContext.SaveChanges();
            return Ok(novaKarta);
        }
    }
}

