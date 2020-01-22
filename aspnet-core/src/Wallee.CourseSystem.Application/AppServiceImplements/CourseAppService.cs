using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Wallee.CourseSystem.AggregateRootModels.Courses;
using Wallee.CourseSystem.AppServiceInterfaces;
using Wallee.CourseSystem.Dtos.Courses;

namespace Wallee.CourseSystem.AppServiceImplements
{
    public class CourseAppService : CrudAppService<Course, CourseDto, Guid, PagedAndSortedResultRequestDto, CreateCourseDto, UpdateCourseDto>, ICourseAppService
    {
        public CourseAppService(ICourseRepository repository) : base(repository)
        {
        }
    }
}
