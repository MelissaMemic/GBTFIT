using GBT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;


namespace GBT.Controllers
{
    public class CityController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public CityController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<Grad> GetGradovi()
        {
            return Ok(_dbContext.Grad.ToList());
        }
    }
}

