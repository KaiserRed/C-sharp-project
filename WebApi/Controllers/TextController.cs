using Microsoft.AspNetCore.Mvc;
using Contracts;
using Microsoft.AspNetCore.Http.Features;

namespace WebApi.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly ITextService _textService;

        public TextController(ITextService textService)
        {
            _textService = textService;
        }

        [HttpGet("uppercase")]
        public IActionResult ToUpper(string input)
        {
            return Ok(_textService.ToUpper(input));
        }
         [HttpGet("concat")]
        public IActionResult Concat(string str1, string str2)
        {
            return Ok(_textService.Concat(str1, str2));
        }
    }
}