using Fullstack_Example.Architecture.Application.Commands.Topics;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    //[Route("[controller]")]
    public class CommandTestController : ControllerBase
    {
        private IMediator _mediator;
        public CommandTestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public object Get()
        {
            //_mediator.Send(new CreateTopicRequest(new Command()));
            return _mediator.Send(new CreateTopicRequest(new Command()));
        }
    }
}
