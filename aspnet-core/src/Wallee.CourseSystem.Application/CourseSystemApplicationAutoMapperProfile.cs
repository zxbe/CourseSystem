using AutoMapper;
using Wallee.CourseSystem.AggregateRootModels.Teachers;
using Wallee.CourseSystem.Dtos;
using Wallee.CourseSystem.Dtos.Teachers;

namespace Wallee.CourseSystem
{
    public class CourseSystemApplicationAutoMapperProfile : Profile
    {
        public CourseSystemApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Teacher, TeacherDto>();
            CreateMap<CreateTeacherDto, Teacher>();
            CreateMap<UpdateTeacherDto, Teacher>();
        }
    }
}
