﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Department
    {
        public int DepartmentID{get;set;}
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get;set;}
        public Department() { Employees = new HashSet<Employee>();}
       
    }
}
