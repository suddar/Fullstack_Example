using AutoMapper;
using Fullstack_Example.Architecture.Application.Commands.Abstractions;
using Fullstack_Example.Architecture.Application.DataObjects.CourseDtos;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;
using Fullstack_Example.Architecture.Domain.Commands;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fullstack_Example.Architecture.Application.Commands.Topics
{
    public class GetCourseByIdRequest : BaseRequest, IRequest<object?>
    {
        public GetCourseByIdRequest(Command command) : base(command)
        {
        }
    }

    public class GetCourseByIdRequestHandler : BaseDbContext, IRequestHandler<GetCourseByIdRequest, object?>
    {
        public GetCourseByIdRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(GetCourseByIdRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (requestData == null) return default;

            var entityDto = JsonConvert.DeserializeObject<GetCourseDto>(requestData);
            if (entityDto == null) return default;

            var entity = await dbContext
                .Set<Course>()
                .Where(x => x.Id == entityDto.Id)
                .ProjectTo<GetCourseDto>(mapper.ConfigurationProvider)
                .FirstAsync();

            return entity;
        }
    }
}
