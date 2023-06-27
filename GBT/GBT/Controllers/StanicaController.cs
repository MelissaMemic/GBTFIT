using GBT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;

namespace GBT.Controllers
{
    public class StanicaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public StanicaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<Stanica> GetStanice()
        {
            return Ok(_dbContext.Stanica.ToList());
        }

        //[Authorize]
        //[HttpGet]
        //public ActionResult<Stanica> GetDrzava()
        //{
        //    return Ok(_dbContext.Stanica.ToList());
        //}
    }
}

