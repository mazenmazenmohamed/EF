using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class EnterpriceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer
            ("Data Source=DESKTOP-ND5BE27\\MSSQLSERVER01;Initial Catalog=EnterpriceDB;Integrated Security =true;Encrypt=false;TrustServerCertificate=true;");
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<TrainingCourse> TrainingCourses { get; set; }
    }
}
