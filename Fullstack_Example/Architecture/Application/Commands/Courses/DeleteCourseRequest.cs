using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class DeleteCourseRequest : BaseRequest, IRequest<object?>
    {
        public DeleteCourseRequest(Command command) : base(command)
        {
        }
    }

    public class DeleteCourseRequestHandler : BaseDbContext, IRequestHandler<DeleteCourseRequest, object?>
    {
        public DeleteCourseRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(DeleteCourseRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Delete Course");
            var requestData = request?.RequestData?.ToString();
            if (requestData == null) return default;

            var entityDto = JsonConvert.DeserializeObject<DeleteCourseDto>(requestData);
            if (entityDto == null) return new DeleteCourseDto { IsSuccess = false };

            var entity = await dbContext.Set<Course>().FindAsync(entityDto.Id);
            if (entity == null) return new DeleteCourseDto { IsSuccess = false };

            dbContext.Remove(entity);
            await dbContext.SaveChangesAsync();

            return new DeleteCourseDto { Id = entity.Id, IsSuccess = true };
        }
    }
}
