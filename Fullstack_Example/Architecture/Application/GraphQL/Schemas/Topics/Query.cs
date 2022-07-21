namespace Fullstack_Example.Architecture.Application.GraphQL.Schemas.Topics
{
    public class Query
    {
        public async Task<Topic?> GetTopic(int id, AppDbContext dbContext)
        {
            return await dbContext.Topics
                .Include(t => t.Courses)
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Topic>?> GetTopics([Service] AppDbContext dbContext)
        {
            return await dbContext.Topics.ToListAsync();
        }

        //[UsePaging]
        [UseProjection]
        //[UseFiltering]
        //[UseSorting]
        public IQueryable<Topic> GetAllTopics(AppDbContext dbContext)
        {
            return dbContext.Topics;
        }
    }
}
