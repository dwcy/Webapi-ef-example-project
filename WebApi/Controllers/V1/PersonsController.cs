using ITHS.Webapi.Contexts;
using ITHS.Webapi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHS.Webapi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        PersonService _personService;
        
        public PersonsController()
        {
            _personService = new PersonService();
        }

        [HttpGet]
        public IActionResult Get(string firstName)
        {
            var person = _personService.FindPersonsByFirstName(firstName);
            return Ok(person);
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            _personService.AddPerson(person);
            return Ok();
        }
    }
}
