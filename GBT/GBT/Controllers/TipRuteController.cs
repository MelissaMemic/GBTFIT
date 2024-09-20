using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBT.Models;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TipRuteController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public TipRuteController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<TipRute> GetTipRute()
        {
            return Ok(_dbContext.TipRute.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<TipRute> GetTipRuteById(int id)
        {
            var tipRute = _dbContext.TipRute.FirstOrDefault(k => k.ID == id);
            if (tipRute == null)
            {
                return NotFound();
            }
            return Ok(tipRute);
        }
    }
}

