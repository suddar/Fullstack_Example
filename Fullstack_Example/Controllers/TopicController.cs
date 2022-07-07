using Fullstack_Example.Architecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : EntityControllerBase
    {
        public TopicController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        #region CRUD
        [HttpPost]
        public async Task<CreateResult<Topic>?> CreateEntity([FromBody] TopicDto entityToCreateInput)
        {
            var entityToCreate = _mapper.Map<Topic>(entityToCreateInput);
            await _entityService.Add(entityToCreate);
            await _dbContext.SaveChangesAsync();
            return new CreateResult<Topic>(entityToCreate);
        }

        [HttpDelete("{id}")]
        public async Task<DeleteResult<bool>?> DeleteEntity(int id)
        {
            var entityToDelete = _dbContext.Find<Topic>(id);
            if (entityToDelete == null) return new DeleteResult<bool>(false);
            _dbContext.Remove(entityToDelete);
            await _dbContext.SaveChangesAsync();
            return new DeleteResult<bool>(true);
        }

        [HttpGet]
        public async Task<GetResult<IEnumerable<TopicDto>>?> GetEntities()
        {
            var entities = await _dbContext.Set<Topic>()
                .Include(x => x.Courses)
                .ProjectTo<TopicDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new GetResult<IEnumerable<TopicDto>>(entities);
        }

        [HttpGet("{id}")]
        public async Task<GetResult<Topic>?> GetEntityById(int id)
        {
            var entity = await _dbContext.Set<Topic>()
                .Where(x => x.Id == id)
                .Include(_ => _.Courses)
                .FirstAsync();
            if (entity == null) return null;
            return new GetResult<Topic>(entity);
        }

        [HttpPut]
        public async Task<UpdateResult<Topic>?> UpdateEntity([FromBody] TopicDto entityToUpdateInput)
        {
            var entityToUpdate = await _dbContext.FindAsync<Topic>(entityToUpdateInput.Id);
            if (entityToUpdate == null) return null;

            entityToUpdate.Name = entityToUpdateInput.Name;
            _dbContext.Update(entityToUpdate);
            await _dbContext.SaveChangesAsync();

            return new UpdateResult<Topic>(entityToUpdate);
        }
        #endregion
    }
}
