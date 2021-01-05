using Microsoft.AspNetCore.Mvc;

namespace SystemCheckServer.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class HomeController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            
            return Ok("Debh");
            
        }
    }
}