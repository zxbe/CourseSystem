using System;
using Volo.Abp.Domain.Repositories;

namespace Wallee.CourseSystem.AggregateRootModels.Teachers
{
    public interface ITeacherRepository : IRepository<Teacher, Guid>
    {

    }
}
