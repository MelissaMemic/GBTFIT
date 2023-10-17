using GBT.Models;
using GBT.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;

namespace GBT.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VoznjaController : ControllerBase
    {
        private readonly MojDBContext _dbContext;
        public VoznjaController(MojDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult<Voznja> GetVoznja()
        {
            return Ok(_dbContext.Voznja.ToList());
        }

        [HttpGet]
        public ActionResult GetVoznjeInfo([FromQuery] VoznjaInfoVM vm)
        {
            var voznje = new List<Voznja>();

            voznje = _dbContext.Voznja.Where(x => x.PocetnaDestinacijaID == vm.PolaznaStanica&& x.KrajnjaDestinacijaID == vm.PovratnaStanica&&x.DatumVoznje==vm.DatumPolaska).ToList();

            return Ok(voznje);
        }

        //[Authorize]
        [HttpGet("{id}")]
        public ActionResult<Voznja> GetVoznjaById(int id)
        {
            var voznja = _dbContext.Voznja.FirstOrDefault(k => k.ID == id);
            if (voznja == null)
            {
                return NotFound(); // Return 404 if the resource with the specified ID is not found

            }
            return Ok(voznja);

        }
    }
}

