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
    public class PosiljkaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public PosiljkaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<Posiljka> GetPosiljka()
        {
            return Ok(_dbContext.Posiljka.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Posiljka> GetPosiljkaById(int id)
        {
            var posiljka = _dbContext.Posiljka.FirstOrDefault(k => k.ID == id);
            if (posiljka == null)
            {
                return NotFound();
            }
            return Ok(posiljka);
        }

    }
}

