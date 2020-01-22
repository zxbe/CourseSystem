using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Wallee.CourseSystem.Dtos.Teachers;

namespace Wallee.CourseSystem.AppServiceInterfaces
{
    public interface ITeacherAppService 
        : ICrudAppService<TeacherDto, Guid, PagedAndSortedResultRequestDto, CreateTeacherDto, UpdateTeacherDto>
    {
    }
}
