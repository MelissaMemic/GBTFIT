using GBT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;


namespace GBT.Controllers
{
    public class DrzavaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public DrzavaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<Drzava> GetDrzave()
        {
            return Ok(_dbContext.Drzava.ToList());
        }


    }
}

