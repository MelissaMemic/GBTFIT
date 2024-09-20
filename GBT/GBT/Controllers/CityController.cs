using GBT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;


namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CityController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public CityController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<Grad> GetGradovi()
        {
            return Ok(_dbContext.Grad.ToList());
        }

        [HttpGet("{name}")]
        public ActionResult<List<Grad>> GetGradByName(string name)
        {
            var Grad = _dbContext.Grad.Where(x => x.Naziv.Contains(name)).ToList();
            if (Grad.Any())
            {
                return Ok(Grad);

            }
            return NotFound(); // Return 404 if the resource with the specified ID is not found

        }

    }
}

