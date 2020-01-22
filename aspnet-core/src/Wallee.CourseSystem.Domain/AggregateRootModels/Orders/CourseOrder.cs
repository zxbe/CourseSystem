using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using Wallee.CourseSystem.Enums;

namespace Wallee.CourseSystem.AggregateRootModels.Orders
{
    public class CourseOrder : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; private set; }
        public Guid StudentId { get; private set; }
        public Guid CourseId { get; private set; }
        public CourseOrderStatus CourseOrderStatus { get; private set; }
        private CourseOrder() { }
        public CourseOrder(Guid id, Guid tenantId, Guid studentId, Guid courseId)
        {
            Check.NotNull(studentId, nameof(studentId));
            Check.NotNull(courseId, nameof(courseId));
            Id = id;
            TenantId = tenantId;
            StudentId = studentId;
            CourseId = courseId;
        }
    }
}
