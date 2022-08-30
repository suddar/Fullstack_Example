using AutoMapper;
using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.CourseDtos;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.EntityFrameworkCore;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class GetTopicByIdRequest : BaseRequest, IRequest<IEnumerable<GetTopicDto>>
    {
        public GetTopicByIdRequest(Command command) : base(command)
        {
        }
    }

    public class GetTopicByIdRequestHandler : BaseDbContext, IRequestHandler<GetTopicsRequest, IEnumerable<GetTopicDto>>
    {
        private readonly IMapper _mapper;
        public GetTopicByIdRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _mapper = serviceProvider.GetRequiredService<IMapper>();
        }

        public async Task<IEnumerable<GetTopicDto>> Handle(GetTopicsRequest request, CancellationToken cancellationToken)
        {
            var entities = await dbContext.Set<Topic>()
            .ProjectTo<GetTopicDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
            return entities;
        }
    }
}
