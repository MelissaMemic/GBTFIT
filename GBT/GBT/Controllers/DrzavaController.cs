using GBT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;


namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DrzavaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public DrzavaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<Drzava> GetDrzave()
        {
            return Ok(_dbContext.Drzava.ToList());
        }

        [HttpGet("{name}")]
        public ActionResult<List<Drzava>> GetDrzavaByName(string name)
        {
            var Drzava = _dbContext.Grad.Where(x => x.Naziv.Contains(name)).ToList();
            if (Drzava.Any())
            {
                return Ok(Drzava);

            }
            return NotFound(); // Return 404 if the resource with the specified ID is not found

        }

    }
}

