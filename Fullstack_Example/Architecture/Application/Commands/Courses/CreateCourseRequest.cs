using Fullstack_Example.Architecture.Application.DataObjects.CourseDtos;
using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class CreateCourseRequest : BaseRequest, IRequest<object?>
    {
        public CreateCourseRequest(Command command) : base(command)
        {
        }
    }

    public class CreateCourseRequestHandler : BaseDbContext, IRequestHandler<CreateCourseRequest, object?>
    {
        public CreateCourseRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(CreateCourseRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (request == null || requestData == null) return default;

            var entity = JsonConvert.DeserializeObject<Course>(requestData);
            if (entity == null) return default;

            await dbContext.AddAsync(entity, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new CreateCourseDto { Name = entity.Name };
        }
    }
}
