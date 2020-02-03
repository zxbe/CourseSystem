using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;
using Wallee.CourseSystem.AggregateRootModels.Courses;

namespace Wallee.CourseSystem.AggregateRootModels.Students
{
    public interface IStudentRepository : IRepository<Student, Guid>
    {
    }
}
