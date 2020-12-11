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
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            positionComboBox.DataSource = null;
            positionComboBox.Items.Clear();

            departmentComboBox.DataSource = null;
            departmentComboBox.Items.Clear();

            using (var context = new PineappleContext())
            {
                context.Positions.Load();
                context.Departments.Load();
                DbSet<Position> positions = context.Positions;
                DbSet<Department> departments = context.Departments;

                foreach (Position position in positions)
                {
                    positionComboBox.Items.Add(position.Name);
                }
                foreach (Department department in departments)
                {
                    departmentComboBox.Items.Add(department.Name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                context.Employees.Load();
                var newEmployee = new Employee();

                newEmployee.Name = nameTextBox.Text;
                newEmployee.Surname = surnameTextBox.Text;
                newEmployee.DateOfBirth = birthDayDateTimePicker.Value;
                newEmployee.Position = positionComboBox.Text;
                newEmployee.Department = departmentComboBox.Text;
                context.Employees.Add(newEmployee);
                context.SaveChanges();

                Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
