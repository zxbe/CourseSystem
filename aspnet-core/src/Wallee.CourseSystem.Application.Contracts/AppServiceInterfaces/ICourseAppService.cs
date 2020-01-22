using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Wallee.CourseSystem.Dtos.Courses;

namespace Wallee.CourseSystem.AppServiceInterfaces
{
    public interface ICourseAppService : ICrudAppService<CourseDto, Guid, PagedAndSortedResultRequestDto, CreateCourseDto, UpdateCourseDto>
    {
    }
}
