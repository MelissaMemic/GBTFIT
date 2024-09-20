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
    public class LojalnostProgramController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public LojalnostProgramController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<LojalnostProgram> GetLojalnostProgram()
        {
            return Ok(_dbContext.LojalnostProgram.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<LojalnostProgram> GetLojalnostProgramById(int id)
        {
            var lojalnostProgram = _dbContext.LojalnostProgram.FirstOrDefault(k => k.ID == id);
            if (lojalnostProgram == null)
            {
                return NotFound();
            }
            return Ok(lojalnostProgram);
        }
    }

}

