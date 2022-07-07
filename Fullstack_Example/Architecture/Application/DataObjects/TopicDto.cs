namespace Fullstack_Example.Architecture.Application.DataObjects
{
    public class TopicDto
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
