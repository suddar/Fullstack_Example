using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class CreateTopicRequest : BaseRequest, IRequest<object?>
    {
        public CreateTopicRequest(Command command) : base(command)
        {
        }
    }

    public class CreateTopicRequestHandler : BaseDbContext, IRequestHandler<CreateTopicRequest, object?>
    {
        public CreateTopicRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(CreateTopicRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (request == null || requestData == null) return default;

            var entity = JsonConvert.DeserializeObject<Topic>(requestData);
            if (entity == null) return default;

            await dbContext.AddAsync(entity, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new CreateTopicDto { Name = entity.Name };
        }
    }
}
