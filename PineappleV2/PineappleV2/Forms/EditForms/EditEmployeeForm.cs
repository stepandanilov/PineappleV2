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

namespace PineappleV2.Forms.EditForms
{
    public partial class EditEmployeeForm : Form
    {
        public int id { get; set; }
        public EditEmployeeForm( int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                var editedEmployee = context.Employees.Find(id);

                editedEmployee.Name = nameTextBox.Text;
                editedEmployee.Surname = surnameTextBox.Text;
                editedEmployee.DateOfBirth = birthDayDateTimePicker.Value;
                editedEmployee.Position = positionComboBox.Text;
                editedEmployee.Department = departmentComboBox.Text;

                context.SaveChanges();
                Close();
            }
            using (var context = new PineappleContext())
            {
                var editedEmployee = context.Employees.Find(id);
                nameTextBox.Text = context.Employees.Find(id).Name;
                surnameTextBox.Text = context.Employees.Find(id).Surname;
                birthDayDateTimePicker.Value = context.Employees.Find(id).DateOfBirth;
                positionComboBox.SelectedItem = context.Employees.Find(id).Position;
                departmentComboBox.SelectedItem = context.Employees.Find(id).Department;
            }
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
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

            using (var context = new PineappleContext())
            {
                var editedEmployee = context.Employees.Find(id);
                nameTextBox.Text = context.Employees.Find(id).Name;
                surnameTextBox.Text = context.Employees.Find(id).Surname;
                birthDayDateTimePicker.Value = context.Employees.Find(id).DateOfBirth;
                positionComboBox.SelectedItem = context.Employees.Find(id).Position;
                departmentComboBox.SelectedItem = context.Employees.Find(id).Department;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Удалить этого работника из базы данных?",
                                    "Подтверждение удаления",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (var context = new PineappleContext())
                {
                    context.Employees.Load();
                    //add remove from department and computer

                    context.Employees.Remove(context.Employees.Find(id));
                    context.SaveChanges();
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
