namespace Fullstack_Example.Architecture.Application.Services
{
    public interface ICommandService
    {
        object? Handle(Command command);
    }
}