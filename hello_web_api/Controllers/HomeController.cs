using Microsoft.AspNetCore.Mvc;

namespace hello_web_api.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public String GetMessage()
        {
            return "Hello ASP.NET Core Web API";
        }
    }
}
