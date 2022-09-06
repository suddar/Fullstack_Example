namespace Fullstack_Example.Architecture.Application.DataObjects.CourseDtos
{
    public class CreateCourseDto
    {
        public string? Name { get; set; }
        public int TopicId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
