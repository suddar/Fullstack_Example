using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Controllers.Abstractions
{
    public abstract class EntityControllerBase<TEntity> where TEntity : BaseEntity
    {
        protected readonly IEntityService<TEntity> _entityService;

        public EntityControllerBase(IEntityService<TEntity> entityService)
        {
            _entityService = entityService;
        }

        [HttpGet()]
        public virtual async Task<IEnumerable<TEntity>> GetEntities()
        {
            return await _entityService.GetALl();
        }

        [HttpGet("{id}")]
        public virtual async Task<TEntity?> GetTEntityById(int id)
        {
            return await _entityService.GetByID(id);
        }

        [HttpPost()]
        public virtual async Task<TEntity> AddEntity([FromBody] TEntity entity)
        {
            return await _entityService.CreateEntity(entity);
        }

        [HttpPut()]
        public virtual async Task<TEntity?> UpdateTEntity([FromBody] TEntity entity)
        {
            return await _entityService.UpdateEntity(entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<bool> Delete(int id)
        {
            return await _entityService.DeleteEntity(id);
        }
    }
}
