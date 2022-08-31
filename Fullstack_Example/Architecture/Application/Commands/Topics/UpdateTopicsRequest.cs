using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class UpdateTopicRequest : BaseRequest, IRequest<UpdateTopicDto?>
    {
        public UpdateTopicRequest(Command command) : base(command)
        {
        }
    }

    public class UpdateTopicsRequestHandler : BaseDbContext, IRequestHandler<UpdateTopicRequest, UpdateTopicDto?>
    {
        public UpdateTopicsRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<UpdateTopicDto?> Handle(UpdateTopicRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (requestData == null) return default;

            var entityDto = JsonConvert.DeserializeObject<UpdateTopicDto>(requestData);
            if (entityDto == null) return default;

            var entity = await dbContext.FindAsync<Topic>(entityDto.Id);
            if (entity == null || entity.Name == null) return default;

            entity.Name = entityDto.Name;
            dbContext.Update(entity);

            await dbContext.SaveChangesAsync(cancellationToken);

            return entityDto;
        }
    }
}
