namespace Fullstack_Example.Application.Services
{
    public interface IEntityService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetALl();
        Task<TEntity?> GetByID(int id);
        Task<TEntity> CreateEntity(TEntity entity);
        Task<TEntity?> UpdateEntity(TEntity entity);
        Task<bool> DeleteEntity(int id);
    }
}
