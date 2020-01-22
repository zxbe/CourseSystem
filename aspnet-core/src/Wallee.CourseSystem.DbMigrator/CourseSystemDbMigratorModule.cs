using Wallee.CourseSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Wallee.CourseSystem.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CourseSystemEntityFrameworkCoreDbMigrationsModule),
        typeof(CourseSystemApplicationContractsModule)
        )]
    public class CourseSystemDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
