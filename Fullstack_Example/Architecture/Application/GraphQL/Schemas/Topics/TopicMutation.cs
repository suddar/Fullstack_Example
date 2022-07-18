using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;

namespace Fullstack_Example.Architecture.Application.GraphQL.Schemas.Topics
{
    public class TopicMutation
    {
        public async Task<Topic> AddTopic(string name, AppDbContext dbContext)
        {
            var newTopic = new Topic { Name = name };
            await dbContext.AddAsync(newTopic);
            await dbContext.SaveChangesAsync();
            return newTopic;
        }

        public async Task<Topic> UpdateTopic(string name, AppDbContext dbContext)
        {
            var newTopic = new Topic { Name = name };
            await dbContext.AddAsync(newTopic);
            await dbContext.SaveChangesAsync();
            return newTopic;
        }

        public async Task<Topic?> DeleteTopic(int id, AppDbContext dbContext)
        {
            var topicToDelete = await dbContext.Topics.FindAsync(id);
            dbContext.Remove(topicToDelete);
            await dbContext.SaveChangesAsync();
            return default;
        }
    }
}
