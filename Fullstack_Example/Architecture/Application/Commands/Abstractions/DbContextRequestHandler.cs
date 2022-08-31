using AutoMapper;

namespace Fullstack_Example.Architecture.Application.Commands.Abstractions
{
    public abstract class BaseDbContext
    {
        protected readonly AppDbContext dbContext;
        protected readonly IMapper mapper;
        public BaseDbContext(IServiceProvider serviceProvider)
        {
            dbContext = serviceProvider.GetRequiredService<AppDbContext>();
            mapper = serviceProvider.GetRequiredService<IMapper>();
        }
    }
}
