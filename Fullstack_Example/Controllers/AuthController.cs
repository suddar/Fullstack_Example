using Fullstack_Example.Architecture.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ICommandService _commandService;
        public AuthController(ICommandService commandService)
        {
            _commandService = commandService;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Post([FromBody] Command command)
        {
            return Ok(_commandService.AuthHandle(command));
        }
    }
}
