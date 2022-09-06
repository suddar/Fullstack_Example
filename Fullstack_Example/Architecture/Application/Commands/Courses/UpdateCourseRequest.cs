using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.CourseDtos;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class UpdateCourseRequest : BaseRequest, IRequest<object?>
    {
        public UpdateCourseRequest(Command command) : base(command)
        {
        }
    }

    public class UpdateCourseRequestHandler : BaseDbContext, IRequestHandler<UpdateCourseRequest, object?>
    {
        public UpdateCourseRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(UpdateCourseRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (requestData == null) return default;

            var entityDto = JsonConvert.DeserializeObject<UpdateCourseDto>(requestData);
            if (entityDto == null) return default;

            var entity = await dbContext.FindAsync<Course>(entityDto.Id);
            if (entity == null || entity.Name == null) return default;

            entity.Name = entityDto.Name;
            entity.Content = entityDto.Content;
            dbContext.Update(entity);

            await dbContext.SaveChangesAsync(cancellationToken);

            return entityDto;
        }
    }
}
