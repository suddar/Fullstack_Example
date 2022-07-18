namespace Fullstack_Example.Architecture.Application.GraphQL.Queries
{
    public class Query
    {
        public async Task<Topic?> GetTopic(int id, AppDbContext dbContext)
        {
            return await dbContext.Topics
                //.FindAsync(id);
                //.Include(t => t.Courses)
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Topic>?> GetTopics([Service] AppDbContext dbContext)
        {
            return await dbContext.Topics.ToListAsync();
        }
    }
}
