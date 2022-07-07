namespace Fullstack_Example.Architecture.Domain.Entities
{
    public class Topic : AuditableEntity
    {
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
