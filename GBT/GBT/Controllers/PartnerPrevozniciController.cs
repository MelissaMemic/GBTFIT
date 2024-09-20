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
    public class PartnerPrevozniciController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public PartnerPrevozniciController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<PartneriPrevoznici> GetPartneriPrevoznici()
        {
            return Ok(_dbContext.PartneriPrevoznici.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<PartneriPrevoznici> GetPartneriPrevozniciById(int id)
        {
            var partneriPrevoznici = _dbContext.PartneriPrevoznici.FirstOrDefault(k => k.ID == id);
            if (partneriPrevoznici == null)
            {
                return NotFound();
            }
            return Ok(partneriPrevoznici);
        }
    }
}

