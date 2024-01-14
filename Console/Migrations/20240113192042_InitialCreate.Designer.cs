﻿// <auto-generated />
using System;
using Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Console.Migrations
{
    [DbContext(typeof(EnterpriceContext))]
    [Migration("20240113192042_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Console.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Console.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DepartmentsDepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentsDepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Console.TrainingCourse", b =>
                {
                    b.Property<int>("CourseNumper")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseNumper"));

                    b.Property<int>("CourseDuration")
                        .HasColumnType("int")
                        .HasColumnName("Duration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseNumper");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EmployeeTrainingCourse", b =>
                {
                    b.Property<int>("EmployeesID")
                        .HasColumnType("int");

                    b.Property<int>("TrainingCoursesCourseNumper")
                        .HasColumnType("int");

                    b.HasKey("EmployeesID", "TrainingCoursesCourseNumper");

                    b.HasIndex("TrainingCoursesCourseNumper");

                    b.ToTable("EmployeeTrainingCourse");
                });

            modelBuilder.Entity("Console.Employee", b =>
                {
                    b.HasOne("Console.Department", "Departments")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentsDepartmentID");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("EmployeeTrainingCourse", b =>
                {
                    b.HasOne("Console.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Console.TrainingCourse", null)
                        .WithMany()
                        .HasForeignKey("TrainingCoursesCourseNumper")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Console.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}