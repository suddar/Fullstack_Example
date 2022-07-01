using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnerController : EntityControllerBase<Learner>
    {
        public LearnerController(IEntityService<Learner> entityService) : base(entityService)
        {
        }
    }
}
