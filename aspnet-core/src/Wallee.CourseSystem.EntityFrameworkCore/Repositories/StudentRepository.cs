using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Wallee.CourseSystem.AggregateRootModels.Courses;
using Wallee.CourseSystem.AggregateRootModels.Students;
using Wallee.CourseSystem.EntityFrameworkCore;

namespace Wallee.CourseSystem.Repositories
{
    public class StudentRepository : EfCoreRepository<CourseSystemDbContext, Student, Guid>, IStudentRepository
    {
        public StudentRepository(IDbContextProvider<CourseSystemDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
