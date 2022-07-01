using Microsoft.EntityFrameworkCore;

namespace Fullstack_Example.Architecture.Application.Commands.Base
{
    #region GetEntitiesCommand
    public class GetEntitiesCommand<TEntity> : IRequest<GetEntitiesResult<TEntity>>
        where TEntity : AuditableEntity
    {

    }

    public class GetEntitiesHandler<TEntity> : EntityContext, IRequestHandler<GetEntitiesCommand<TEntity>, GetEntitiesResult<TEntity>>
        where TEntity : AuditableEntity
    {
        public GetEntitiesHandler(AppDbContext dbContext) : base(dbContext) { }

        public async Task<GetEntitiesResult<TEntity>> Handle(GetEntitiesCommand<TEntity> request, CancellationToken cancellationToken)
        {
            DbSet<TEntity> allEntities = dbContext.Set<TEntity>();
            if (allEntities == null) return new GetEntitiesResult<TEntity> { StatusCode = BehaviorStatus.Failure };

            return new GetEntitiesResult<TEntity> { Entities = allEntities, StatusCode = BehaviorStatus.Success };
        }
    }
    #endregion

    public class GetEntitiesResult<TEntity> : GetEntitiesResult, IBehaviorResult
         where TEntity : AuditableEntity
    {
        public IEnumerable<TEntity>? Entities { get; set; }
    }

    public class GetEntitiesResult : IBehaviorResult
    {
        public BehaviorStatus StatusCode { get; set; }
        public string? Message { get; set; } = null;
    }
}
