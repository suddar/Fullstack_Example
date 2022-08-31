namespace Fullstack_Example.Application.Services
{
    public interface IEntityService
    {
        Task<TEntity?> AddAsync<TEntity>(TEntity entity);
        Task<bool> Delete<TEntity>(int id) where TEntity : AuditableEntity;
        Task<IEnumerable<TEntity>> GetAll<TEntity>() where TEntity : AuditableEntity;
        Task<IEnumerable<TEntityDto>> GetAllTo<TEntity, TEntityDto>() where TEntity : AuditableEntity;
        Task<TEntity?> GetById<TEntity>(int id) where TEntity : AuditableEntity;
        Task<TEntity?> UpdateEntity<TEntity>(TEntity entity) where TEntity : AuditableEntity;
    }
}