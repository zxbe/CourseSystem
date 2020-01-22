using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Wallee.CourseSystem.AggregateRootModels.Teachers
{
    /// <summary>
    /// 教师的资历证书
    /// </summary>
    public class TeacherQualification : Entity<Guid>
    {
        /// <summary>
        /// 教师外键
        /// </summary>
        public virtual Guid TeacherId { get; protected set; }
        /// <summary>
        /// 证书名称
        /// </summary>
        public virtual string QualificationName { get; protected set; }
        /// <summary>
        /// 颁发日期
        /// </summary>
        public virtual DateTime IssueDate { get; protected set; }
        /// <summary>
        /// 到期日期
        /// </summary>
        public virtual DateTime ExpireDate { get; protected set; }
        /// <summary>
        /// 颁发机构
        /// </summary>
        public virtual string IssueOrganization { get; protected set; }
        /// <summary>
        /// 证书编号
        /// </summary>
        public virtual string QualificationNo { get; protected set; }
        /// <summary>
        /// 证书是否过期
        /// </summary>
        public bool IsExpired
        {
            get
            {
                return ExpireDate.Millisecond > DateTime.Now.Millisecond;
            }
        }
        protected TeacherQualification()
        {

        }
        public TeacherQualification(Guid teacherId, string qualificationName, DateTime issueDate, DateTime? expireDate, string issueOrganization, string qualificationNo)
        {
            TeacherId = teacherId;
            QualificationName = qualificationName;
            IssueDate = issueDate;
            ExpireDate = expireDate ?? DateTime.MaxValue;
            IssueOrganization = issueOrganization;
            QualificationNo = qualificationNo;
        }
    }
}
