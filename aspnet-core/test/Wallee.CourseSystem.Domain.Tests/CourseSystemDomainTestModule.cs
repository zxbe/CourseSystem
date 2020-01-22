using Wallee.CourseSystem.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Wallee.CourseSystem
{
    [DependsOn(
        typeof(CourseSystemEntityFrameworkCoreTestModule)
        )]
    public class CourseSystemDomainTestModule : AbpModule
    {

    }
}