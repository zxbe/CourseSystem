using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Wallee.CourseSystem.Dtos.Students;

namespace Wallee.CourseSystem.AppServiceInterfaces
{
    public interface IStudentAppService : ICrudAppService<StudentDto, Guid, PagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {
    }
}
