namespace Fullstack_Example.Architecture.Application.DataObjects.CourseDtos
{
    public class UpdateCourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
