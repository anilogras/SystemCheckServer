using Microsoft.AspNetCore.Mvc;
using SystemCheckServer.Helpers;

namespace SystemCheckServer.Controllers
{
    [Route("api/Hdd")]
    [ApiController]
    public class HddController : ControllerBase
    {

        LinuxHelpers _linuxCommand = new  LinuxHelpers();

        public IActionResult Get()
        {
            var result = _linuxCommand.LinuxCommandExec("service apache2 status");

            return Ok(result);
        }

    }
}