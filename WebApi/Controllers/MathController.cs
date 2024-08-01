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

         [HttpGet("Sum")]
        public IActionResult Sum(int a, int b)
        {
            return Ok(_mathService.Sum(a, b));
        }
    }
}