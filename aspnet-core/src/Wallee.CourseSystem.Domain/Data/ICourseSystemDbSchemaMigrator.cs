using System.Threading.Tasks;

namespace Wallee.CourseSystem.Data
{
    public interface ICourseSystemDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
