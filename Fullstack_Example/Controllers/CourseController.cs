using Fullstack_Example.Architecture.Application.DataObjects;
using Fullstack_Example.Architecture.Domain.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : EntityControllerBase
    {
        public CourseController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        #region CRUD
        [HttpPost]
        public async Task<CreateResult<Course>?> CreateEntity([FromBody] CourseDto entityToCreateInput)
        {
            var entityToCreate = _mapper.Map<Course>(entityToCreateInput);
            await _entityService.Add(entityToCreate);
            await _dbContext.SaveChangesAsync();
            return new CreateResult<Course>(entityToCreate);
        }

        [HttpDelete("{id}")]
        public async Task<DeleteResult<bool>?> DeleteEntity(int id)
        {
            var entityToDelete = _dbContext.Find<Course>(id);
            if (entityToDelete == null) return new DeleteResult<bool>(false);
            _dbContext.Remove(entityToDelete);
            await _dbContext.SaveChangesAsync();
            return new DeleteResult<bool>(true);
        }

        [HttpGet]
        public async Task<GetResult<IEnumerable<CourseDto>>?> GetEntities()
        {
            var entities = await _dbContext.Set<Course>()
                .ProjectTo<CourseDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new GetResult<IEnumerable<CourseDto>>(entities);
        }

        [HttpGet("{id}")]
        public async Task<GetResult<Course>?> GetEntityById(int id)
        {
            var entity = await _dbContext.Set<Course>()
                .Where(x => x.Id == id)
                .FirstAsync();
            if (entity == null) return null;
            return new GetResult<Course>(entity);
        }

        [HttpPut]
        public async Task<UpdateResult<Course>?> UpdateEntity([FromBody] CourseDto entityToUpdateInput)
        {
            var entityToUpdate = await _dbContext.FindAsync<Course>(entityToUpdateInput.Id);
            if (entityToUpdate == null) return null;

            entityToUpdate.Name = entityToUpdateInput.Name;
            _dbContext.Update(entityToUpdate);
            await _dbContext.SaveChangesAsync();

            return new UpdateResult<Course>(entityToUpdate);
        }
        #endregion
    }
}
