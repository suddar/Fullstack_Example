using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Example.Architecture.Application.Interfaces
{
    public interface IEntityBehaviour<TResultEntity, TCreateEntity, TUpdateEntity>
    {
        Task<CreateResult<TResultEntity>?> CreateEntity([FromBody] TCreateEntity entityToCreateInput);
        Task<GetResult<IEnumerable<TResultEntity>>?> GetEntities();
        Task<GetResult<TResultEntity>?> GetEntityById(int id);
        Task<UpdateResult<TResultEntity>?> UpdateEntity([FromBody] TUpdateEntity entityToUpdateInput);
        Task<DeleteResult<bool>?> DeleteEntity(int id);
    }
}
