namespace Fullstack_Example.Architecture.Application.Commands.Base
{
    public class DeleteEntityCommand<TResult> : IRequest<IEnumerable<TResult>>
    {
    }

    public class DeleteEntityHandler<TResult> : EntityContext, IRequestHandler<DeleteEntityCommand<TResult>, IEnumerable<TResult>>
    {
        public DeleteEntityHandler(AppDbContext dbContext) : base(dbContext) { }

        public Task<IEnumerable<TResult>> Handle(DeleteEntityCommand<TResult> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
