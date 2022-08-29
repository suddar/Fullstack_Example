namespace Fullstack_Example.Architecture.Application.Commands.Abstractions
{
    public abstract class DbContextRequestHandler
    {
        protected readonly AppDbContext dbContext;
        public DbContextRequestHandler(IServiceProvider serviceProvider)
        {
            dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        }
    }
}
