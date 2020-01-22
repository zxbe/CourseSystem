using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wallee.CourseSystem.Data;
using Volo.Abp.DependencyInjection;

namespace Wallee.CourseSystem.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreCourseSystemDbSchemaMigrator 
        : ICourseSystemDbSchemaMigrator, ITransientDependency
    {
        private readonly CourseSystemMigrationsDbContext _dbContext;

        public EntityFrameworkCoreCourseSystemDbSchemaMigrator(CourseSystemMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}