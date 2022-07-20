namespace Fullstack_Example.Architecture.Application.GraphQL.Schemas.Courses
{
    public class CourseQuery
    {
        public async Task<Course?> GetTopic(int id, AppDbContext dbContext)
        {
            return await dbContext.Courses
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Course>?> GetCourses([Service] AppDbContext dbContext)
        {
            return await dbContext.Courses.ToListAsync();
        }

        public async Task<IEnumerable<Course>?> GetCoursesByTopicId(int topicId, [Service] AppDbContext dbContext)
        {
            return await dbContext.Courses
                .Where(x => x.TopicId == topicId)
                .ToListAsync();
        }

        //[UsePaging]
        [UseProjection]
        //[UseFiltering]
        //[UseSorting]
        public IQueryable<Course> GetAllCourses(AppDbContext dbContext)
        {
            return dbContext.Courses;
        }
    }
}
