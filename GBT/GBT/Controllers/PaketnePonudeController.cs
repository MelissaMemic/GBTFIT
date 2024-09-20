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
    public class PaketnePonudeController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public PaketnePonudeController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<PaketnePonude> GetPaketnePonude()
        {
            return Ok(_dbContext.PaketnePonude.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<PaketnePonude> GetPaketnePonudeById(int id)
        {
            var paketnePonude = _dbContext.PaketnePonude.FirstOrDefault(k => k.ID == id);
            if (paketnePonude == null)
            {
                return NotFound();
            }
            return Ok(paketnePonude);
        }
    }
}

