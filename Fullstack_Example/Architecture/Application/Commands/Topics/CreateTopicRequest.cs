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
            var data = request.RequestData;
            var entity = JsonConvert.DeserializeObject<Topic>(data.ToString());

            Console.WriteLine("---------------------------------");
            Console.WriteLine(entity.Name);
            Console.WriteLine(data);
            Console.WriteLine("---------------------------------");

            if (entity == null) return default;

            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return new CreateTopicDto { Name = entity.Name };
        }
    }
}
