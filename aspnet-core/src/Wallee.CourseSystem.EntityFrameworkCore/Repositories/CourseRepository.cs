using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Wallee.CourseSystem.AggregateRootModels.Courses;
using Wallee.CourseSystem.EntityFrameworkCore;

namespace Wallee.CourseSystem.Repositories
{
    public class CourseRepository : EfCoreRepository<CourseSystemDbContext, Course, Guid>, ICourseRepository
    {
        public CourseRepository(IDbContextProvider<CourseSystemDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
