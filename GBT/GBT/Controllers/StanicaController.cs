using GBT.Models;
using GBT.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;

namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StanicaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public StanicaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult<Stanica> GetStanice()
        {
            return Ok(_dbContext.Stanica.ToList());
        }
        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<Stanica> GetStanicaById(int id)
        {
            var stanica = _dbContext.Stanica.FirstOrDefault(k => k.ID == id);
            if (stanica==null)
            {
                return NotFound(); // Return 404 if the resource with the specified ID is not found
            }
            return Ok(stanica);
        }

        [HttpGet]
        public ActionResult GetStaniceById([FromBody] EndStartStanicaVM vm)
        {
            var stanice = new List<Stanica>();
            var ids = new List<int>();

            if (vm.IsStartDestination)
            {
                ids = _dbContext.Voznja.Where(x => x.PocetnaDestinacijaID == vm.ID).Select(x => x.KrajnjaDestinacijaID).ToList();
            }
            else
            {
                ids = _dbContext.Voznja.Where(x => x.KrajnjaDestinacijaID == vm.ID).Select(x => x.PocetnaDestinacijaID).ToList();

            }
            if (ids.Any())
            {
                foreach(var id in ids)
            {
                stanice.Add(_dbContext.Stanica.Where(x => x.ID == id).FirstOrDefault());

            }
            }
            
            return Ok(stanice);
        }
    }
}

