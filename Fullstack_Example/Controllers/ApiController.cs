using Fullstack_Example.Architecture.Application.Services;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly CommandService _commandService;
        public ApiController(CommandService handlerService)
        {
            _commandService = handlerService;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Post([FromBody] Command command)
        {
            var result = _commandService.Handler(command);
            return Ok(result);
        }
    }
}
