using EsercizioEnviroment.Services;
using Microsoft.AspNetCore.Mvc;

namespace EsercizioEnviroment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _service;

        public GreetingController(IGreetingService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetGreeting()
        {
            var result = _service.GetGreeting();
            return Ok(new {message = result});
        }
    }
}
