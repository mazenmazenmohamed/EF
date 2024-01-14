﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinEF.Entities;

namespace WinEF.Context;

public partial class EnterpriceDBContext : DbContext
{
    public EnterpriceDBContext()
    {
    }

    public EnterpriceDBContext(DbContextOptions<EnterpriceDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-ND5BE27\\MSSQLSERVER01;Initial Catalog=EnterpriceDB;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasMany(d => d.TrainingCoursesCourseNumpers).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeTrainingCourse",
                    r => r.HasOne<Course>().WithMany().HasForeignKey("TrainingCoursesCourseNumper"),
                    l => l.HasOne<Employee>().WithMany().HasForeignKey("EmployeesID"),
                    j =>
                    {
                        j.HasKey("EmployeesID", "TrainingCoursesCourseNumper");
                        j.ToTable("EmployeeTrainingCourse");
                        j.HasIndex(new[] { "TrainingCoursesCourseNumper" }, "IX_EmployeeTrainingCourse_TrainingCoursesCourseNumper");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}