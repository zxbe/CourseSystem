﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;
using Wallee.CourseSystem.AggregateRootModels.Courses;
using Wallee.CourseSystem.AggregateRootModels.Students;
using Wallee.CourseSystem.AggregateRootModels.Teachers;

namespace Wallee.CourseSystem.EntityFrameworkCore
{
    public static class CourseSystemDbContextModelCreatingExtensions
    {
        public static void ConfigureCourseSystem(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CourseSystemConsts.DbTablePrefix + "YourEntities", CourseSystemConsts.DbSchema);

            //    //...
            //});
            builder.Entity<Teacher>(it =>
            {
                it.ToTable("Teachers");
                it.HasKey(it => it.Id);
                it.ConfigureByConvention();
                //it.OwnsOne(it => it.Address, a => a.WithOwner());
                it.Property(it => it.Description).HasMaxLength(200).IsRequired(false);
                it.Property(it => it.Name).HasMaxLength(20).IsRequired();
                it.Property(it => it.NickName).HasMaxLength(20).IsRequired(false);
                it.Property(it => it.Gender).IsRequired();

            });
            builder.Entity<TeacherQualification>(it =>
            {
                it.ToTable("TeacherQualifications");
                it.HasKey(it => it.Id);
                it.ConfigureByConvention();
                it.Property(it => it.IssueDate).IsRequired();
                it.Property(it => it.QualificationName).HasMaxLength(100).IsRequired();
                it.Property(it => it.QualificationNo).HasMaxLength(100).IsRequired();
                it.Property(it => it.IssueDate).IsRequired();
                it.Property(it => it.ExpireDate).IsRequired().HasDefaultValue(DateTime.MaxValue);
                it.Property(it => it.IssueOrganization).IsRequired().HasMaxLength(100);
                it.HasOne<Teacher>().WithMany(it => it.Qualifications)
                .HasForeignKey(it => it.TeacherId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            });
            builder.Entity<Course>(it =>
            {
                it.ToTable("Courses");
                it.HasKey(it => it.Id);
                it.ConfigureByConvention();
                it.Property(it => it.Name).IsRequired().HasMaxLength(100);
                it.Property(it => it.Description).IsRequired().HasMaxLength(300);
                it.Property(it => it.CourseType).IsRequired();
                it.HasOne<Teacher>().WithMany().HasForeignKey(it => it.TeacherId)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<CourseRegistration>(it =>
            {
                it.ToTable("CourseRegistrations");
                it.HasKey(it => new { it.StudentId, it.CourseId });
                it.ConfigureByConvention();
                it.HasOne<Course>().WithMany().HasForeignKey(it => it.CourseId).OnDelete(DeleteBehavior.Cascade);
                it.HasOne<Student>().WithMany().HasForeignKey(it => it.StudentId).OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Student>(it =>
            {
                it.ToTable("Students");
                it.HasKey(it => it.Id);
                it.ConfigureByConvention();
                it.Property(it => it.Name).IsRequired().HasMaxLength(100);
                it.Property(it => it.Gender).IsRequired();
                it.Property(it => it.BirthDate).IsRequired();
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}