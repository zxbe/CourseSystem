using System;
using Volo.Abp.Domain.Entities;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    /// <summary>
    /// 培训班
    /// </summary>
    public class Class : Entity
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
        /// 培训班开始时间
        /// </summary>
        public virtual DateTime StartDate { get; private set; }
        /// <summary>
        /// 培训班结束时间
        /// </summary>
        public virtual DateTime EndDate { get; private set; }
        /// <summary>
        /// 主键
        /// </summary>
        /// <returns></returns>
        public override object[] GetKeys()
        {
            return new object[] { CourseId, ClassRoomId };
        }
        protected Class() { }
        public Class(Guid id)
        {

        }
    }
}
