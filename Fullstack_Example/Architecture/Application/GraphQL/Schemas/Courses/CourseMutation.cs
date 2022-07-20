using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;

namespace Fullstack_Example.Architecture.Application.GraphQL.Schemas.Courses
{
    public class CourseMutation
    {
        public async Task<Topic> AddTopic(string name, AppDbContext dbContext)
        {
            var newTopic = new Topic { Name = name };
            await dbContext.AddAsync(newTopic);
            await dbContext.SaveChangesAsync();
            return newTopic;
        }

        public async Task<Topic> UpdateTopic(int id, string name, AppDbContext dbContext)
        {
            var topicToUpdate = await dbContext.Topics.FindAsync(id);
            topicToUpdate.Name = name;
            await dbContext.SaveChangesAsync();
            return topicToUpdate;
        }

        public async Task<Topic?> DeleteTopic(int id, AppDbContext dbContext)
        {
            var topicToDelete = await dbContext.Topics.FindAsync(id);
            _ = dbContext.Remove(topicToDelete);
            await dbContext.SaveChangesAsync();
            return default;
        }
    }
}
