using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class DeleteTopicsRequest : BaseRequest, IRequest<DeleteTopicDto>
    {
        public DeleteTopicsRequest(Command command) : base(command)
        {
        }
    }

    public class DeleteTopicsRequestHandler : BaseDbContext, IRequestHandler<DeleteTopicsRequest, DeleteTopicDto>
    {
        public DeleteTopicsRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<DeleteTopicDto> Handle(DeleteTopicsRequest request, CancellationToken cancellationToken)
        {
            var topicDto = JsonConvert.DeserializeObject<DeleteTopicDto>(request.RequestData.ToString());
            if (topicDto == null) return new DeleteTopicDto { IsSuccess = false };

            var entity = await dbContext.Topics.FindAsync(topicDto.Id);
            if (entity == null) return new DeleteTopicDto { IsSuccess = false };

            _ = dbContext.Remove(entity);
            _ = await dbContext.SaveChangesAsync();

            return new DeleteTopicDto { Id = entity.Id, IsSuccess = true };
        }
    }
}
