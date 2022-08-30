using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class UpdateTopicRequest : BaseRequest, IRequest<IEnumerable<GetTopicDto>>
    {
        public UpdateTopicRequest(Command command) : base(command)
        {
        }
    }

    public class UpdateTopicsRequestHandler : BaseDbContext, IRequestHandler<GetTopicsRequest, IEnumerable<GetTopicDto>>
    {
        public UpdateTopicsRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public Task<IEnumerable<GetTopicDto>> Handle(GetTopicsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
