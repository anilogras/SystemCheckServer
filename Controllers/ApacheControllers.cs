using Microsoft.AspNetCore.Mvc;
using SystemCheckServer.Helpers;
using SystemCheckServer.ReturnTypes;

namespace SystemCheckServer.Controllers
{

    [ApiController]
    [Route("api/Apache")]
    public class ApacheControllers : ControllerBase
    {
        LinuxHelpers _linuxCommand = new LinuxHelpers();
        public IActionResult GetStatus()
        {
            ApacheStatusResult result =new ApacheStatusResult ();
            var apacheStatusText = _linuxCommand.LinuxCommandExec("service apache2 status");
            result.Response = apacheStatusText;
            return Ok(result);
        }
    }
}