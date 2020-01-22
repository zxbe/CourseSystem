using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.TenantManagement;
using Wallee.CourseSystem.Enums;

namespace Wallee.CourseSystem.Dtos.Teachers
{
    public class TeacherDto : EntityDto<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 教师描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 教师证书
        /// </summary>
        public ICollection<TeacherQualificationDto> Qualifications { get; set; }
        public TenantDto Tenant { get; set; }
    }
}
