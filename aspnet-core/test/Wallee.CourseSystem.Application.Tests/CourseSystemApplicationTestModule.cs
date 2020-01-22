using Volo.Abp.Modularity;

namespace Wallee.CourseSystem
{
    [DependsOn(
        typeof(CourseSystemApplicationModule),
        typeof(CourseSystemDomainTestModule)
        )]
    public class CourseSystemApplicationTestModule : AbpModule
    {

    }
}