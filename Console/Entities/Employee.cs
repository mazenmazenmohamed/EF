using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Adderess { get; set; }
        public virtual Department Departments { get; set; }
        public virtual ICollection<TrainingCourse> TrainingCourses { get; set; }
    }
}
