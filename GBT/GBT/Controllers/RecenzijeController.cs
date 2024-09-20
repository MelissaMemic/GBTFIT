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
    public class RecenzijeController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public RecenzijeController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<RecenzijeVozova> GetRecenzije()
        {
            return Ok(_dbContext.RecenzijeVozova.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<RecenzijeVozova> GetRecenzijeById(int id)
        {
            var recenzijeVozova = _dbContext.RecenzijeVozova.FirstOrDefault(k => k.ID == id);
            if (recenzijeVozova == null)
            {
                return NotFound();
            }
            return Ok(recenzijeVozova);
        }

    }
}

