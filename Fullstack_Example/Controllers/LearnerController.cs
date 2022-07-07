using Fullstack_Example.Architecture.Application.DataObjects;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnerController : EntityControllerBase
    {
        public LearnerController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
