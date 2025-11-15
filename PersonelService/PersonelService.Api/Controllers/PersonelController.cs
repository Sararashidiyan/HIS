using Microsoft.AspNetCore.Mvc;

namespace PersonelService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonelController : ControllerBase
    {
        public PersonelController()
        {
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
