using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;
using WinEF.Context;

namespace WinEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => context?.Dispose();
        }
        EnterpriceDBContext context = new EnterpriceDBContext();

        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            context.Employees.Load();
            //var result = from E in context.Employees select new { E.ID, E.Name, E.Salary, E.Adderess };
            grdViewEmployee.DataSource = context.Employees.Local.ToBindingList();
        }

        private void SavebtnClick(object sender, EventArgs e)
        {
            grdViewEmployee.EndEdit();
            context.SaveChanges();
            var result = (from E in context.Employees select new { E.ID, E.Name, E.Salary, E.Adderess }).OrderBy(E => E.ID).ToList();
            grdViewEmployee.DataSource = result;
        }
        //Delete
        private void Delete_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = GetID();
            var employeeToDelete = context.Employees.Find(selectedEmployeeId);

            if (employeeToDelete != null)
            {
                // Remove the employee from the DbContext
                context.Employees.Remove(employeeToDelete);

                // Save changes to the database
                context.SaveChanges();

                // Refresh the DataGridView or update other controls

                context.Employees.Load();
                grdViewEmployee.DataSource = context.Employees.Local.ToBindingList();
            }
        }
        //Sort
        private void Sort_Click(object sender, EventArgs e)
        {
           
            var result = (from E in context.Employees select new { E.ID, E.Name, E.Salary, E.Adderess }).OrderBy(E=>E.ID).ToList();
            grdViewEmployee.DataSource = result;
             

        }

        private void Search_Click(object sender, EventArgs e)
        {
           
            int SearchedEmployee =
                Convert.ToInt32(SearchBox.Text);
            grdViewEmployee.DataSource = context.Employees.FromSql
                ($"select * from Employees where ID = {SearchedEmployee}").ToList();


        }
        private int GetID()
        {
            if (grdViewEmployee.SelectedRows.Count > 0)
            {

                int selectedEmployeeId = Convert.ToInt32(grdViewEmployee.SelectedRows[0].Cells["ID"].Value);
                return selectedEmployeeId;
            }
            else
            {
                // No row selected, return -1 or any default value
                return -1;
            }
        }
        //Load
        private void Load_Click(object sender, EventArgs e)
        {
           
            context.Employees.Load();
            //var result =(from E in context.Employees select new {E.ID,E.Name,E.Salary,E.Adderess } );
            grdViewEmployee.DataSource = context.Employees.Local.ToBindingList();
        }
    }
}