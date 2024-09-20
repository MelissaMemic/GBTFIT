using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobitelShop.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HistorijaPlacanjaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public HistorijaPlacanjaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<HstorijaPlacanja> GetHistorijaPlacanja()
        {
            return Ok(_dbContext.HstorijaPlacanja.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<HstorijaPlacanja> GetHistorijaPlacanjaById(int id)
        {
            var stanica = _dbContext.HstorijaPlacanja.FirstOrDefault(k => k.ID == id);
            if (stanica == null)
            {
                return NotFound(); 
            }
            return Ok(stanica);
        }
    }
}

