using Microsoft.AspNetCore.Mvc;

namespace APIInteractiveLab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string GetHome()
        {
            return "Welcome to the Drinks API";
        }
    }
}