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
    public class OtkazivanjeRezervacijeController : ControllerBase
    {
        
            private readonly MojDBContext _dbContext;
            public OtkazivanjeRezervacijeController(MojDBContext dbContext)
            {
                this._dbContext = dbContext;
            }

            [HttpGet]
            public ActionResult<OtkazivanjaRezervacija> GetOtkazivanjaRezervacija()
            {
                return Ok(_dbContext.OtkazivanjaRezervacija.ToList());
            }

            [HttpGet("{id}")]
            public ActionResult<OtkazivanjaRezervacija> GetOtkazivanjaRezervacijaById(int id)
            {
                var otkazivanjaRezervacija = _dbContext.OtkazivanjaRezervacija.FirstOrDefault(k => k.ID == id);
                if (otkazivanjaRezervacija == null)
                {
                    return NotFound();
                }
                return Ok(otkazivanjaRezervacija);
            }
        
    }
}

