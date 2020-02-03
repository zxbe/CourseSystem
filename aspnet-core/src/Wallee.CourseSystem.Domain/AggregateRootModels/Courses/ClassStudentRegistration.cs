using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    /// <summary>
    /// 培训班的报名学员
    /// </summary>
    public class ClassStudentRegistration : AuditedEntity
    {
        /// <summary>
        /// 培训班的外键
        /// </summary>
        public virtual Guid ClassId { get; private set; }
        /// <summary>
        /// 学员的外键
        /// </summary>
        public virtual Guid StudentId { get; private set; }

        public override object[] GetKeys()
        {
            return new object[] { ClassId, StudentId };
        }
    }
}
