using Fullstack_Example.Architecture.Domain.Commands;

namespace Fullstack_Example.Architecture.Application.Commands.Abstractions
{
    public abstract class BaseRequest
    {
        public Command Command { get; set; }
        public BaseRequest(Command command)
        {
            Command = command;
        }

        public string RequestData
        {
            get => !string.IsNullOrEmpty(Command.RequestData) ? Command.RequestData : "";
        }
    }
}
