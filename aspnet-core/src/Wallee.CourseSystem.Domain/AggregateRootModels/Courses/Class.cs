using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    /// <summary>
    /// Class用来描述培训班的概念。
    /// 关于培训班的逻辑：培训班约定了三件事，①培训班的培训的课程②讲这个课程的老师③培训班的授课地点（教室）
    /// 培训班不同于班级的概念，培训班的形式更加灵活，学生可以选择多个培训班。
    /// 培训班和学生之间是多对多的关系，所以需要一个中间表来描述这个关系。
    /// </summary>
    public class Class : AuditedEntity<Guid>
    {
        /// <summary>
        /// 课程Id
        /// </summary>
        public virtual Guid CourseId { get; private set; }
        /// <summary>
        /// 教室Id
        /// </summary>
        public virtual Guid ClassRoomId { get; private set; }
        /// <summary>
        /// 授课老师Id
        /// </summary>
        public virtual Guid TeacherId { get; private set; }
        /// <summary>
        /// 培训班名称
        /// </summary>
        public virtual string ClassName { get; private set; }
        /// <summary>
        /// 培训班描述
        /// </summary>
        public virtual string ClassDescription { get; private set; }
        /// <summary>
        /// 培训班开始时间
        /// </summary>
        public virtual DateTime StartDate { get; private set; }
        /// <summary>
        /// 培训班结束时间
        /// </summary>
        public virtual DateTime EndDate { get; private set; }
        /// <summary>
        /// 培训班的报名学生
        /// </summary>
        public virtual ICollection<ClassStudentRegistration> ClassStudentRegistrations { get; private set; }
        protected Class() { }
        public Class(Guid id)
        {

        }
    }
}
