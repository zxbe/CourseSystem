using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    public interface ICourseRepository : IRepository<Course, Guid>
    {
    }
}
