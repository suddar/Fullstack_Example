using AutoMapper;
using Fullstack_Example.Architecture.Application.DataObjects.CourseDtos;
using Fullstack_Example.Architecture.Application.DataObjects.TopicDtos;

namespace Fullstack_Example.Architecture.Application.MapperProfiles
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            // Topic
            CreateMap<Topic, CreateTopicDto>().ReverseMap();
            CreateMap<Topic, GetTopicDto>().ReverseMap();
            CreateMap<Topic, UpdateTopicDto>().ReverseMap();

            //Course
            CreateMap<Course, CreateCourseDto>().ReverseMap();
            CreateMap<Course, GetCourseDto>().ReverseMap();
            CreateMap<Course, UpdateCourseDto>().ReverseMap();
        }
    }
}
