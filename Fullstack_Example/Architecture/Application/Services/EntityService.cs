
namespace Fullstack_Example.Application.Services
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : BaseEntity
    {
        private AppDbContext _dbContext;
        public EntityService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> CreateEntity(TEntity entity)
        {
            _ = await _dbContext.AddAsync(entity);
            _ = await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteEntity(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
            if (entity == null) return false;
            _ = _dbContext.Remove(entity);
            return true;
        }

        public async Task<IEnumerable<TEntity>> GetALl()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByID(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
            if (entity == null) return default(TEntity);
            return entity;
        }

        public async Task<TEntity?> UpdateEntity(TEntity entity)
        {
            var entityToUpdate = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == entity.Id);
            if (entityToUpdate == null) return default(TEntity);

            entityToUpdate = entity;
            await _dbContext.SaveChangesAsync();

            return entityToUpdate;
        }
    }
}
