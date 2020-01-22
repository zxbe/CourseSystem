﻿using Microsoft.EntityFrameworkCore;
using Wallee.CourseSystem.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;
using Wallee.CourseSystem.AggregateRootModels.Teachers;
using Wallee.CourseSystem.AggregateRootModels.Students;
using Wallee.CourseSystem.AggregateRootModels.Courses;

namespace Wallee.CourseSystem.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See CourseSystemMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class CourseSystemDbContext : AbpDbContext<CourseSystemDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside CourseSystemDbContextModelCreatingExtensions.ConfigureCourseSystem
         */
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public CourseSystemDbContext(DbContextOptions<CourseSystemDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                //Moved customization to a method so we can share it with the CourseSystemMigrationsDbContext class
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureCourseSystem method */

            builder.ConfigureCourseSystem();
        }
    }
}
