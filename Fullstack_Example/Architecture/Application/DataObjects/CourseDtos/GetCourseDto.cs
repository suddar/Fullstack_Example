namespace Fullstack_Example.Architecture.Application.DataObjects.CourseDtos
{
    public class GetCourseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TopicId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
