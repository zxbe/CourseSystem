using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.TenantManagement;
using Wallee.CourseSystem.Enums;

namespace Wallee.CourseSystem.Dtos.Teachers
{
    public class UpdateTeacherDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(20)]
        public virtual string Name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [Required]
        [StringLength(50)]
        public virtual string NickName { get; set; }
        /// <summary>
        /// 教师描述
        /// </summary>
        [Required]
        [StringLength(200)]
        public virtual string Description { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required]
        public virtual Gender Gender { get; set; }
        /// <summary>
        /// 教师证书
        /// </summary>
        [Required]
        public virtual ICollection<TeacherQualificationDto> Qualifications { get; set; }
        [Required]
        public virtual Guid TenantId { get; set; }
    }
}
