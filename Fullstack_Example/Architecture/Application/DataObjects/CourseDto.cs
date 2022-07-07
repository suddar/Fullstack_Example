namespace Fullstack_Example.Architecture.Application.DataObjects
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TopicId { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
