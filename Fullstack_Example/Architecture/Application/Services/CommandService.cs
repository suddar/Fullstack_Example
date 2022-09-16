using Fullstack_Example.Architecture.Application.Commands.Topics;
using Fullstack_Example.Architecture.Application.Commands.Users;

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

        public object? AuthHandle(Command command)
        {
            var response = _mediator.Send(GetAuthCommandHandler(command));
            if (response == null) return null;

            return response.Result;
        }

        private IRequest<object?> GetAuthCommandHandler(Command command)
        {
            return command.Name switch
            {
                #region Authentication
                CommandNames.UserLogin => new LoginRequest(command),
                CommandNames.UserRegister => new RegisterRequest(command),
                #endregion
                _ => throw new NotImplementedException()
            };
        }

        private IRequest<object?> GetCommandHandler(Command command)
        {
            return command.Name switch
            {
                #region Authentication
                CommandNames.UserLogin => new LoginRequest(command),
                CommandNames.UserRegister => new RegisterRequest(command),
                #endregion

                #region Topic commands
                CommandNames.CreateTopic => new CreateTopicRequest(command),
                CommandNames.GetTopics => new GetTopicsRequest(command),
                CommandNames.GetTopicById => new GetTopicByIdRequest(command),
                CommandNames.UpdateTopic => new UpdateTopicRequest(command),
                CommandNames.DeleteTopic => new DeleteTopicsRequest(command),
                #endregion

                #region Course commands
                CommandNames.CreateCourse => new CreateCourseRequest(command),
                CommandNames.GetCourses => new GetCoursesRequest(command),
                CommandNames.GetCourseById => new GetCourseByIdRequest(command),
                CommandNames.UpdateCourse => new UpdateCourseRequest(command),
                CommandNames.DeleteCourse => new DeleteCourseRequest(command),
                #endregion

                _ => throw new NotImplementedException()
            };
        }
    }
}
