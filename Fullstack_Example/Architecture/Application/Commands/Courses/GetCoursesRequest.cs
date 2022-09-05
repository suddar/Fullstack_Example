using Fullstack_Example.Architecture.Application.DataObjects.CourseDtos;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class GetCoursesRequest : BaseRequest, IRequest<object?>
    {
        public GetCoursesRequest(Command command) : base(command)
        {
        }
    }

    public class GetCoursesRequestHandler : BaseDbContext, IRequestHandler<GetCoursesRequest, object?>
    {
        public GetCoursesRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(GetCoursesRequest request, CancellationToken cancellationToken)
        {
            var entities = await dbContext
                .Set<Course>()
                .ProjectTo<GetCourseDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return entities;
        }
    }
}
