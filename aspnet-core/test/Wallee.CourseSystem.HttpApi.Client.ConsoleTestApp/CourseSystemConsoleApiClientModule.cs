using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Wallee.CourseSystem.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(CourseSystemHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class CourseSystemConsoleApiClientModule : AbpModule
    {
        
    }
}
