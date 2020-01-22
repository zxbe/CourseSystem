using System;
using Volo.Abp.Application.Dtos;
using Wallee.CourseSystem.Enums;

namespace Wallee.CourseSystem.Dtos.Courses
{
    public class CourseDto : EntityDto<Guid>
    {

        public Guid TeacherId { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 课程描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime PublishDate { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public virtual DateTime ExpireDate { get; set; }
        /// <summary>
        /// 课程类型
        /// </summary>
        public CourseType CourseType { get; set; }
    }
}
