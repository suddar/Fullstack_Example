using AutoMapper;
using Fullstack_Example.Architecture.Application.DataObjects;

namespace Fullstack_Example.Architecture.Application.MapperProfiles
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            CreateMap<Topic, TopicDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
        }
    }
}
