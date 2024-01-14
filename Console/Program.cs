//This app we use code first then create DB by migration
using Microsoft.EntityFrameworkCore;


namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EnterpriceContext context = new EnterpriceContext())
            {
                //very bad to use
               // context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();

                //so we use ..... migration

                { //Department D01 = new Department() { Name = "Engineering" };
                  //Department D02 = new Department() { Name = "Hr" };


                    //To Insert

                    //context.Departments.Add(D01);
                    //context.Add(D02);//the both are correct
                    //context.SaveChanges();
                    //System.Console.WriteLine(D01.DepartmentID);
                    //System.Console.WriteLine(D02.DepartmentID);
                    //To delete
                    //context.Departments.Remove(context.Departments.First());

                    //To Update
                    //var result = context.Departments.Where(department => department.DepartmentID == 5);
                    //Department d = result.FirstOrDefault();
                    //d.DepartmentID = 1;
                    // result = context.Departments.Where(department => department.DepartmentID == 6);
                    //d = result.FirstOrDefault();
                    //d.DepartmentID = 2;
                    //context.SaveChanges();}

                }
                // TrainingCourse course = new TrainingCourse() {Name="7Habbits", CourseDuration = 12 };
                // context.Add(course);

                context.Database.Migrate();
                //context.Add(new Employee()
                //{
                //    Name = "Mazen",
                //    Salary = 12000,
                //    Adderess = "Maadi"
                //});
                context.SaveChanges();
            }
        }
    }
}

