namespace Fullstack_Example.Architecture.Application.Commands.Base
{
    public class UpdateEntityCommand<TEntity> : IRequest<TEntity>
    {
        public TEntity Entity { get; set; }
    }
}
