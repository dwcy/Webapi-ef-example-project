using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHS.Webapi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from PersonsController");
        }
    }
}
