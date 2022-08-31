using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class DeleteTopicsRequest : BaseRequest, IRequest<DeleteTopicDto?>
    {
        public DeleteTopicsRequest(Command command) : base(command)
        {
        }
    }

    public class DeleteTopicsRequestHandler : BaseDbContext, IRequestHandler<DeleteTopicsRequest, DeleteTopicDto?>
    {
        public DeleteTopicsRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<DeleteTopicDto?> Handle(DeleteTopicsRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (requestData == null) return default;

            var entityDto = JsonConvert.DeserializeObject<DeleteTopicDto>(requestData);
            if (entityDto == null) return new DeleteTopicDto { IsSuccess = false };

            var entity = await dbContext.Topics.FindAsync(entityDto.Id);
            if (entity == null) return new DeleteTopicDto { IsSuccess = false };

            dbContext.Remove(entity);
            await dbContext.SaveChangesAsync();

            return new DeleteTopicDto { Id = entity.Id, IsSuccess = true };
        }
    }
}
