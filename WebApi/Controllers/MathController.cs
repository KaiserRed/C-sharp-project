using Microsoft.AspNetCore.Mvc;
using Contracts;
using Microsoft.AspNetCore.Http.Features;

namespace WebApi.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;

        public MathController(IMathService msvc)
        {
            _mathService = msvc;
        }

        [HttpGet("sum")]
        public IActionResult Sum(double a, double b)
        {
            return Ok(_mathService.Sum(a, b));
        }

        [HttpGet("substraction")]
        public IActionResult Substracion(double a, double b)
        {
            return Ok(_mathService.Substracion(a, b));
        }
        [HttpGet("multiplication")]        
        public IActionResult Multiplication(double a, double b)
        {
            return Ok(_mathService.Multiplication(a, b));
        }
        [HttpGet("division")]
        public IActionResult Division(double a, double b)
        {
            return Ok(_mathService.Division(a, b));
        }
        [HttpGet("pow")]
        public IActionResult Pow(double a, double b)
        {
            return Ok(_mathService.Pow(a, b));
        }
    }
}