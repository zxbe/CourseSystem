using System;
using System.Collections;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using Wallee.CourseSystem.Enums;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        /// <summary>
        /// 租户Id
        /// </summary>
        public Guid? TenantId { get; private set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public virtual string Name { get; private set; }
        /// <summary>
        /// 课程描述
        /// </summary>
        public virtual string Description { get; private set; }
        /// <summary>
        /// 课程类型
        /// </summary>
        public virtual CourseType CourseType { get; private set; }
        /// <summary>
        /// 课程关联的培训班
        /// </summary>
        public virtual ICollection<Class> Classes { get; private set; }
        /// <summary>
        /// 课程单价
        /// </summary>
        public virtual decimal UnitPrice { get; private set; }
        protected Course()
        {

        }
        public Course(Guid id,
            Guid tenantId,
            string name,
            string description,
            CourseType courseType,
            decimal unitPrice)
        {
            Id = id;
            TenantId = tenantId;
            Name = name;
            Description = description;
            CourseType = courseType;
            UnitPrice = unitPrice;
        }
    }
}
