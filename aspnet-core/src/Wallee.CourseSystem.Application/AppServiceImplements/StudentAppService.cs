using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Wallee.CourseSystem.AggregateRootModels.Students;
using Wallee.CourseSystem.AppServiceInterfaces;
using Wallee.CourseSystem.Dtos.Students;

namespace Wallee.CourseSystem.AppServiceImplements
{
    public class StudentAppService : CrudAppService<Student, StudentDto, Guid, PagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {
        public StudentAppService(IStudentsRepository repository) : base(repository)
        {
        }
    }
}
