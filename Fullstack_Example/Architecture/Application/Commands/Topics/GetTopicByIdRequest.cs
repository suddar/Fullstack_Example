using AutoMapper;
using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.CourseDtos;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class GetTopicByIdRequest : BaseRequest, IRequest<GetTopicDto?>
    {
        public GetTopicByIdRequest(Command command) : base(command)
        {
        }
    }

    public class GetTopicByIdRequestHandler : BaseDbContext, IRequestHandler<GetTopicByIdRequest, GetTopicDto?>
    {
        public GetTopicByIdRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<GetTopicDto?> Handle(GetTopicByIdRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (requestData == null) return default;

            var entityDto = JsonConvert.DeserializeObject<GetTopicDto>(requestData);
            if (entityDto == null) return default;

            var entity = await dbContext
                .Set<Topic>()
                .Where(x => x.Id == entityDto.Id)
                .Include(_ => _.Courses)
                .ProjectTo<GetTopicDto>(mapper.ConfigurationProvider)
                .FirstAsync();

            return entity;
        }
    }
}
