using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fullstack_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : EntityControllerBase
    {
        public SeedController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [HttpGet("SeedOrReseed")]
        public async Task SeedOrReseed()
        {
            foreach (var item in _dbContext.Topics)
                _dbContext.Topics.Remove(item);

            foreach (var item in _dbContext.Courses)
                _dbContext.Courses.Remove(item);

            await Seed1();
            await Seed2();
            await Seed3();
        }

        private async Task Seed1()
        {
            var topic = new Topic { Name = "Math & life" };
            var course1 = new Course { Name = "Math course 1", Topic = topic };
            var course2 = new Course { Name = "Math course 2", Topic = topic };
            var course3 = new Course { Name = "Math course 3", Topic = topic };
            var course4 = new Course { Name = "Math course 4", Topic = topic };
            var course5 = new Course { Name = "Math course 5", Topic = topic };

            if (topic.Courses != null)
            {
                topic.Courses.Add(course1);
                topic.Courses.Add(course2);
                topic.Courses.Add(course3);
                topic.Courses.Add(course4);
                topic.Courses.Add(course5);
            }

            if (topic != null)
            {
                await _dbContext.AddAsync(topic);
                await _dbContext.SaveChangesAsync();
            }
        }

        private async Task Seed2()
        {
            var topic = new Topic { Name = "Art" };
            var course1 = new Course { Name = "Art course 1", Topic = topic };
            var course2 = new Course { Name = "Art course 2", Topic = topic };
            var course3 = new Course { Name = "Art course 3", Topic = topic };

            if (topic.Courses != null)
            {
                topic.Courses.Add(course1);
                topic.Courses.Add(course2);
                topic.Courses.Add(course3);
            }

            await _dbContext.AddAsync(topic);
            await _dbContext.SaveChangesAsync();
        }

        private async Task Seed3()
        {
            var topic = new Topic { Name = "English" };
            await _dbContext.AddAsync(topic);

            var course1 = new Course { Name = "English course 1", Topic = topic };
            var course2 = new Course { Name = "English course 2", Topic = topic };
            var course3 = new Course { Name = "English course 3", Topic = topic };
            var course4 = new Course { Name = "English course 4", Topic = topic };

            if (topic.Courses != null)
            {
                topic.Courses.Add(course1);
                topic.Courses.Add(course2);
                topic.Courses.Add(course3);
                topic.Courses.Add(course4);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
