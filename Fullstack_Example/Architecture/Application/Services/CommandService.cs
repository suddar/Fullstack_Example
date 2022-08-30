using Fullstack_Example.Architecture.Application.Commands.Topics;
using Fullstack_Example.Architecture.Domain.Commands;

namespace Fullstack_Example.Architecture.Application.Services
{
    public class CommandService : ICommandService
    {
        private readonly IMediator _mediator;
        public CommandService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public object? Handle(Command command)
        {
            return _mediator.Send(GetCommandHandler(command));
        }

        private IRequest<object?> GetCommandHandler(Command command)
        {
            return command.Name switch
            {
                #region Topic commands
                CommandName.TOPIC_CREATE => new CreateTopicRequest(command),
                CommandName.TOPIC_GET_MULTI => new GetTopicsRequest(command),
                CommandName.TOPIC_GET_BY_ID => new GetTopicByIdRequest(command),
                CommandName.TOPIC_UPDATE => new UpdateTopicRequest(command),
                CommandName.TOPIC_DELETE => new DeleteTopicsRequest(command),
                #endregion
                _ => throw new NotImplementedException(),
            };
        }
    }
}
