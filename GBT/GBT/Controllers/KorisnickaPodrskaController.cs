using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBT.Models;
using GBT.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class KorisnickaPodrskaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public KorisnickaPodrskaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<UpitiKorisnickePodrske> GetUpitiKorisnickePodrske()
        {
            return Ok(_dbContext.UpitiKorisnickePodrske.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<UpitiKorisnickePodrske> GetUpitiKorisnickePodrskeById(int id)
        {
            var upitiKorisnickePodrske = _dbContext.UpitiKorisnickePodrske.FirstOrDefault(k => k.ID == id);
            if (upitiKorisnickePodrske == null)
            {
                return NotFound();
            }
            return Ok(upitiKorisnickePodrske);
        }

        [HttpPost]
        public ActionResult Snimi([FromBody] PorukaSnimiVM x)
        {
            UpitiKorisnickePodrske? noviUpit;
            if (x.ID == 0)
            {
                noviUpit = new UpitiKorisnickePodrske
                {
                    KorisnikID = x.KorisnikID,
                    Sadrzaj=x.Sadrzaj,
                    DatumUpita=DateTime.Now,
                    Status=x.Status

    };

                _dbContext.Add(noviUpit); 
                _dbContext.SaveChanges();
            }
            else
            {
                return BadRequest("pogresan ID");
            }


            return Ok(noviUpit); 
        }

    }
}

