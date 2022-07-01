namespace Fullstack_Example.Architecture.Application.Commands.Abstraction
{
    public abstract class BaseEntityCommand<TEntity>
    {
        public virtual TEntity Entity { get; set; }
    }
}
