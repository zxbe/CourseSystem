using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using Wallee.CourseSystem.Enums;

namespace Wallee.CourseSystem.AggregateRootModels.Teachers
{
    public class Teacher : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        /// <summary>
        /// 租户ID:区别不同学校
        /// </summary>
        public Guid? TenantId { get; protected set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public virtual Guid? UserId { get; protected set; }
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; protected set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public virtual string NickName { get; protected set; }
        /// <summary>
        /// 教师描述
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public virtual Gender Gender { get; protected set; }
        /// <summary>
        /// 教师证书
        /// </summary>
        public virtual ICollection<TeacherQualification> Qualifications { get; protected set; }
        private Teacher() { }
        public Teacher(string name,
            string nickName,
            string description,
            Gender gender)
        {
            Name = name;
            NickName = nickName;
            Description = description;
            Gender = gender;
            Qualifications = new List<TeacherQualification>();
        }
    }
}
