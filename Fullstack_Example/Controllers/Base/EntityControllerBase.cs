using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers.Base
{
    public abstract class EntityControllerBase : ControllerBase
    {
        protected readonly IMediator mediator;

        public EntityControllerBase(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
