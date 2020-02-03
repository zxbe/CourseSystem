using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    public class ClassSchedule : AuditedEntity<Guid>
    {
        /// <summary>
        /// 教室Id
        /// </summary>
        public virtual Guid ClassRoomId { get; private set; }
        /// <summary>
        /// 培训班名称
        /// </summary>
        public virtual string ClassName { get; private set; }
        /// <summary>
        /// 培训班描述
        /// </summary>
        public virtual string ClassDescription { get; private set; }
        /// <summary>
        /// 教室开始占用时间
        /// </summary>
        public virtual DateTime StartDateTime { get; private set; }
        /// <summary>
        /// 教室结束占用时间
        /// </summary>
        public virtual DateTime EndDateTime { get; private set; }
        /// <summary>
        /// 实到学生人数
        /// </summary>
        public virtual int ActualStudentCount { get; private set; }
    }
}
