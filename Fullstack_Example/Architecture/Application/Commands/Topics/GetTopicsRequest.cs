namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class GetTopicsRequest : BaseRequest, IRequest<IEnumerable<GetTopicDto>?>
    {
        public GetTopicsRequest(Command command) : base(command)
        {
        }
    }

    public class GetTopicsRequestHandler : BaseDbContext, IRequestHandler<GetTopicsRequest, IEnumerable<GetTopicDto>?>
    {
        public GetTopicsRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<IEnumerable<GetTopicDto>?> Handle(GetTopicsRequest request, CancellationToken cancellationToken)
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
