using System;
using Volo.Abp.Application.Dtos;

namespace Wallee.CourseSystem.Dtos.Teachers
{
    public class TeacherQualificationDto : EntityDto<Guid>
    {
        public TeacherDto Teacher { get; set; }
        /// <summary>
        /// 证书名称
        /// </summary>
        public string QualificationName { get; set; }
        /// <summary>
        /// 颁发日期
        /// </summary>
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// 到期日期
        /// </summary>
        public DateTime ExpireDate { get; set; }
        /// <summary>
        /// 颁发机构
        /// </summary>
        public string IssueOrganization { get; set; }
        /// <summary>
        /// 证书编号
        /// </summary>
        public string QualificationNo { get; set; }
    }
}
