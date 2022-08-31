namespace Fullstack_Example.Architecture.Application.DataObjects.TopicDtos
{
    public class GetTopicDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
