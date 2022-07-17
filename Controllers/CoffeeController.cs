using Microsoft.AspNetCore.Mvc;
using APIInteractiveLab.Models;

namespace APIInteractiveLab.Controllers
{
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public string GetHome()
        {
            return "Coffee Home";
        }

        [HttpGet("{name}")]
        public Coffee GetCoffee(string? name)
        {
            return new Coffee { Id=-1, Name=name??"latte" };
        }

        [Route("[controller]/lover")]
        [HttpGet]
        public string GetLover()
        {
            return "I like coffee!";
        }
    }
    
}
