using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class GetTopicsRequest : BaseRequest, IRequest<IEnumerable<GetTopicDto>>
    {
        public GetTopicsRequest(Command command) : base(command)
        {
        }
    }

    public class GetTopicsRequestHandler : DbContextRequestHandler, IRequestHandler<GetTopicsRequest, IEnumerable<GetTopicDto>>
    {
        public GetTopicsRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public Task<IEnumerable<GetTopicDto>> Handle(GetTopicsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
