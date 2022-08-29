namespace Fullstack_Example.Architecture.Domain.Commands
{
    public class Command
    {
        public CommandName Name { get; set; }
        public string? RequestData { get; set; }
    }
}
