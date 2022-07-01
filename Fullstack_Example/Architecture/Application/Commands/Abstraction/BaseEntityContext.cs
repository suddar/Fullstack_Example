using Fullstack_Example.Architecture.Infrastructure;

namespace Fullstack_Example.Architecture.Application.Commands.Abstraction
{
    public abstract class EntityContext
    {
        protected readonly AppDbContext dbContext;

        public EntityContext(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
