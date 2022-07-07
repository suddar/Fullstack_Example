using AutoMapper;

namespace Fullstack_Example.Controllers.Abstractions
{
    public abstract class EntityControllerBase
    {
        protected readonly IEntityService _entityService;
        protected readonly IMapper _mapper;
        protected readonly AppDbContext _dbContext;
        public EntityControllerBase(IServiceProvider serviceProvider)
        {
            _entityService = serviceProvider.GetRequiredService<IEntityService>();
            _mapper = serviceProvider.GetRequiredService<IMapper>();
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();    
        }
    }
}
