using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Wallee.CourseSystem.AggregateRootModels.Teachers;
using Wallee.CourseSystem.AppServiceInterfaces;
using Wallee.CourseSystem.Dtos.Teachers;

namespace Wallee.CourseSystem.AppServiceImplements
{
    public class TeacherAppService : CrudAppService<Teacher, TeacherDto, Guid, PagedAndSortedResultRequestDto, CreateTeacherDto, UpdateTeacherDto>, ITeacherAppService
    {

        public TeacherAppService(ITeacherRepository repository) : base(repository)
        {
            // CreatePolicyName = "pangjianxin";

        }
        //protected override IQueryable<Teacher> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        //{
        //    return base.CreateFilteredQuery(input).WhereIf(input.Sorting.StartsWith("1"), it => true);
        //}
    }
}
