using Fullstack_Example.Architecture.Domain.Enums;

namespace Fullstack_Example.Architecture.Application.Commands.Interfaces
{
    public interface IBehaviorResult
    {
        public BehaviorStatus StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
