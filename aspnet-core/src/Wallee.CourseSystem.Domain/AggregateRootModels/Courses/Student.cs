using System;
using Volo.Abp.Domain.Entities.Auditing;
using Wallee.CourseSystem.Enums;

namespace Wallee.CourseSystem.AggregateRootModels.Courses
{
    /// <summary>
    /// 学员
    /// </summary>
    public class Student : AuditedEntity<Guid>
    {
        /// <summary>
        /// 学员名称
        /// </summary>
        public virtual string Name { get; private set; }
        /// <summary>
        /// 学员手机号
        /// </summary>
        public virtual string PhoneNumber { get; private set; }
        /// <summary>
        /// 性别
        /// </summary>
        public virtual Gender Gender { get; private set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public virtual DateTime BirthDate { get; private set; }
        protected Student() { }
        public Student(Guid id,
            string name,
            string phoneNumber,
            Gender gender,
            DateTime birthDate)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Gender = gender;
            BirthDate = birthDate;
        }
    }
}
