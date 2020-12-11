using PineappleV2.Forms.EditForms;
using PineappleV2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PineappleV2
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                EmployeeTable.DataSource = null;
                EmployeeTable.Rows.Clear();
                EmployeeTable.Refresh();

                context.Employees.Load();
                DbSet<Employee> employees = context.Employees;
                int i = 0;
                EmployeeTable.RowCount = employees.Count();

                foreach(Employee employee in employees)
                {
                    EmployeeTable[0, i].Value = employee.Id;
                    EmployeeTable[1, i].Value = employee.Name;
                    EmployeeTable[2, i].Value = employee.Surname;
                    EmployeeTable[3, i].Value = employee.DateOfBirth.ToString("dd.MM.yyyy");
                    EmployeeTable[4, i].Value = employee.Position;
                    EmployeeTable[5, i].Value = employee.Department;
                    i++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeAddForm form = new EmployeeAddForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
        }

        private void EmployeeForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                EmployeeTable.DataSource = null;
                EmployeeTable.Rows.Clear();
                EmployeeTable.Refresh();

                context.Employees.Load();
                DbSet<Employee> employees = context.Employees;
                int i = 0;
                EmployeeTable.RowCount = employees.Count();

                foreach (Employee employee in employees)
                {
                    EmployeeTable[0, i].Value = employee.Id;
                    EmployeeTable[1, i].Value = employee.Name;
                    EmployeeTable[2, i].Value = employee.Surname;
                    EmployeeTable[3, i].Value = employee.DateOfBirth.ToString("dd.MM.yyyy");
                    EmployeeTable[4, i].Value = employee.Position;
                    EmployeeTable[5, i].Value = employee.Department;
                    i++;
                }
            }
        }

        private void EmployeeTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new PineappleContext())
            {
                EditEmployeeForm editClientForm = new EditEmployeeForm(Convert.ToInt32(EmployeeTable.SelectedRows[0].Cells[0].Value));
                editClientForm.ShowDialog();

            }
        }
    }
}
