namespace Fullstack_Example.Architecture.Application.Commands.Abstractions
{
    public abstract class BaseDbContext
    {
        protected readonly AppDbContext dbContext;
        public BaseDbContext(IServiceProvider serviceProvider)
        {
            dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        }
    }
}
