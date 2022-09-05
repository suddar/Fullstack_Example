namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class GetTopicsRequest : BaseRequest, IRequest<object?>
    {
        public GetTopicsRequest(Command command) : base(command)
        {
        }
    }

    public class GetTopicsRequestHandler : BaseDbContext, IRequestHandler<GetTopicsRequest, object?>
    {
        public GetTopicsRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(GetTopicsRequest request, CancellationToken cancellationToken)
        {
            var entities = await dbContext
                .Set<Topic>()
                .Include(x => x.Courses)
                .ProjectTo<GetTopicDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return entities;
        }
    }
}
