using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Wallee.CourseSystem.AggregateRootModels.Orders
{
    public interface ICourseOrderRepository : IRepository<CourseOrder, Guid>
    {
    }
}
