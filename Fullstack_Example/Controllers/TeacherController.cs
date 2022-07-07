using Fullstack_Example.Architecture.Application.DataObjects;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TeacherController : EntityControllerBase
    {
        public TeacherController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
