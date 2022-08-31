
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Fullstack_Example.Application.Services
{
    public class EntityService : IEntityService
    {
        private AppDbContext _dbContext;
        private IMapper _mapper;
        public EntityService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<TEntity?> AddAsync<TEntity>(TEntity entity)
        {
            if (entity == null) return default;
            _ = await _dbContext.AddAsync(entity);
            _ = await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAll<TEntity>() where TEntity : AuditableEntity
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<TEntityDto>> GetAllTo<TEntity, TEntityDto>() where TEntity : AuditableEntity
        {
            return await _dbContext.Set<TEntity>()
                .ProjectTo<TEntityDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<TEntity?> GetById<TEntity>(int id) where TEntity : AuditableEntity
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity == null) return default(TEntity);
            return entity;
        }

        public async Task<TEntity?> UpdateEntity<TEntity>(TEntity entity) where TEntity : AuditableEntity
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Delete<TEntity>(int id) where TEntity : AuditableEntity
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity == null) return false;
            _ = _dbContext.Remove(entity);
            return true;
        }
    }
}
