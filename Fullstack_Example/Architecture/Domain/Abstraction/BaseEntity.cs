namespace Fullstack_Example.Architecture.Domain.Abstraction
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
