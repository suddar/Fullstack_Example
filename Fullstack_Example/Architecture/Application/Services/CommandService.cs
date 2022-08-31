using Fullstack_Example.Architecture.Application.Commands.Topics;

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
            var response = _mediator.Send(GetCommandHandler(command));
            if (response == null) return null;

            return response.Result;
        }

        private static IRequest<object?> GetCommandHandler(Command command)
        {
            return command.Name switch
            {
                #region Topic commands
                CommandNames.CreateTopic => new CreateTopicRequest(command),
                CommandNames.GetTopics => new GetTopicsRequest(command),
                CommandNames.GetTopicById => new GetTopicByIdRequest(command),
                CommandNames.UpdateTopic => new UpdateTopicRequest(command),
                CommandNames.DeleteTopic => new DeleteTopicsRequest(command),
                #endregion
                _ => throw new NotImplementedException(),
            };
        }
    }
}
