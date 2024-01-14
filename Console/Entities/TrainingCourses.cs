using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    //if i dont use convention==default the ef standard so i use DataAnnotation
    [Table("Courses")]
    public class TrainingCourse
    {
        [Key] //pk
        public int CourseNumper {get; set; }
        [Required]///notnull
        [MaxLength(50)]//nvarchar(50)
        public string Name { get; set; }
        [Column("Duration", TypeName = "int")]
        public short CourseDuration { get; set; }
        //Many To MAany
        public virtual ICollection<Employee> Employees { get; set; }
        public TrainingCourse() { Employees = new HashSet<Employee>(); }

    }
}
