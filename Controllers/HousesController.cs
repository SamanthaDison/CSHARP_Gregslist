
using CSHARP_Gregslist.Models;
using CSHARP_Gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_Gregslist.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _hs;
        public HousesController(HousesService hs)
        {
            _hs = hs;
        }

        [HttpGet]
        public ActionResult<List<House>> GetAll()
        {
            try
            {
                return Ok(_hs.GetAll());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{houseId}")]
        public ActionResult<House> GetById(string houseId)
        {

        }

    }


}