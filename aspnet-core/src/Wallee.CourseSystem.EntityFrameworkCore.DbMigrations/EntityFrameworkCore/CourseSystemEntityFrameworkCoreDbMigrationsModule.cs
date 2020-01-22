using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Wallee.CourseSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(CourseSystemEntityFrameworkCoreModule)
        )]
    public class CourseSystemEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CourseSystemMigrationsDbContext>();
        }
    }
}
