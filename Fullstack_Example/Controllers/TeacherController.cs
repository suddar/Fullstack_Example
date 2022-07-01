using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TeacherController : EntityControllerBase<Teacher>
    {
        public TeacherController(IEntityService<Teacher> entityService) : base(entityService)
        {
        }

        [AllowAnonymous]
        public override Task<IEnumerable<Teacher>> GetEntities()
        {
            return base.GetEntities();
        }

        public override Task<Teacher> AddEntity([FromBody] Teacher entity)
        {
            return base.AddEntity(entity);
        }
    }
}
