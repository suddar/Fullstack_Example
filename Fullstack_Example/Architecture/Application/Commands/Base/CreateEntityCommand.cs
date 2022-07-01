namespace Fullstack_Example.Architecture.Application.Commands.Base
{
    public class CreateAuditableEntityCommand<TEntity> : IRequest<CreateEntityResult<TEntity>>
    {
        public TEntity? Entity { get; set; }
    }

    public class CreateAuditableEntityHandler<TEntity> : EntityContext, IRequestHandler<CreateAuditableEntityCommand<TEntity>, CreateEntityResult<TEntity>>
        where TEntity : AuditableEntity, new()
    {
        public CreateAuditableEntityHandler(AppDbContext dbContext) : base(dbContext) { }

        public async Task<CreateEntityResult<TEntity>> Handle(CreateAuditableEntityCommand<TEntity> request, CancellationToken cancellationToken)
        {
            var entity = request.Entity;
            if (entity == null) return new CreateEntityResult<TEntity> { StatusCode = BehaviorStatus.Failure };

            _ = await dbContext.AddAsync<TEntity>(entity, cancellationToken);
            _ = await dbContext.SaveChangesAsync(cancellationToken);

            return new CreateEntityResult<TEntity> { Result = request.Entity, StatusCode = BehaviorStatus.Success };
        }
    }

    public class CreateEntityResult<TEntity> : IBehaviorResult
    {
        public TEntity? Result { get; set; }
        public BehaviorStatus StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
