using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Wallee.CourseSystem.AggregateRootModels.Teachers;
using Wallee.CourseSystem.EntityFrameworkCore;

namespace Wallee.CourseSystem.Repositories
{
    public class TeacherRepository : EfCoreRepository<CourseSystemDbContext, Teacher, Guid>, ITeacherRepository
    {
        public TeacherRepository(IDbContextProvider<CourseSystemDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
