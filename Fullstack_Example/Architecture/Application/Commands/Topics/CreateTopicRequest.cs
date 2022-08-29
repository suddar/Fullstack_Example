using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class CreateTopicRequest : BaseRequest, IRequest<CreateTopicDto>
    {
        public CreateTopicRequest(Command command) : base(command)
        {
        }
    }

    public class CreateTopicRequestHandler : DbContextRequestHandler, IRequestHandler<CreateTopicRequest, CreateTopicDto?>
    {
        public CreateTopicRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<CreateTopicDto?> Handle(CreateTopicRequest request, CancellationToken cancellationToken)
        {
            var entity = JsonConvert.DeserializeObject<Topic>(JsonConvert.SerializeObject(request.RequestData));
            if (entity == null) return null;

            _ = await dbContext.AddAsync(entity);
            _ = await dbContext.SaveChangesAsync();

            return new CreateTopicDto { Name = entity.Name };
        }
    }
}
