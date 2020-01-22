using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    /// <summary>
    /// 教室
    /// </summary>
    public class ClassRoom : AuditedEntity<Guid>
    {
        /// <summary>
        /// 教室名称
        /// </summary>
        public virtual string Name { get; private set; }
        /// <summary>
        /// 描述
        /// </summary>
        public virtual string Description { get; private set; }
        /// <summary>
        /// 校区
        /// </summary>
        public virtual string Zone { get; private set; }
        /// <summary>
        /// 能够容纳的学生数
        /// </summary>
        public virtual int Capacity { get; private set; }
        protected ClassRoom()
        {

        }
        public ClassRoom(Guid id,
            string name,
            string description,
            string zone,
            int capacity)
        {
            Id = id;
            Name = name;
            Description = description;
            Zone = zone;
            Capacity = capacity;
        }
    }
}
