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
    public class ObavestenjaKorisnicimaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public ObavestenjaKorisnicimaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<ObavestenjaKorisnicima> GetObavestenjaKorisnicima()
        {
            return Ok(_dbContext.ObavestenjaKorisnicima.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<ObavestenjaKorisnicima> GetObavestenjaKorisnicimaById(int id)
        {
            var obavestenjaKorisnicima = _dbContext.ObavestenjaKorisnicima.FirstOrDefault(k => k.ID == id);
            if (obavestenjaKorisnicima == null)
            {
                return NotFound();
            }
            return Ok(obavestenjaKorisnicima);
        }

    }
}

