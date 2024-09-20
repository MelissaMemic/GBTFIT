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
    public class OcjenjivanjeZaposlenihController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public OcjenjivanjeZaposlenihController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<OcjenjivanjeZaposlenih> GetOcjenjivanjeZaposlenih()
        {
            return Ok(_dbContext.OcjenjivanjeZaposlenih.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<OcjenjivanjeZaposlenih> GetOcjenjivanjeZaposlenihById(int id)
        {
            var ocjenjivanjeZaposlenih = _dbContext.OcjenjivanjeZaposlenih.FirstOrDefault(k => k.ID == id);
            if (ocjenjivanjeZaposlenih == null)
            {
                return NotFound();
            }
            return Ok(ocjenjivanjeZaposlenih);
        }
    }
}

