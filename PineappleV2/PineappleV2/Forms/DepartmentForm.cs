using PineappleV2.Forms.AddForms;
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

namespace PineappleV2.Forms
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddDepartmentForm form = new AddDepartmentForm();
            form.ShowDialog();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                context.Departments.Load();
                DbSet<Department> departments = context.Departments;
                int i = 0;
                dataGridView1.RowCount = departments.Count();

                foreach (Department department in departments)
                {
                    dataGridView1[0, i].Value = department.Id;
                    dataGridView1[1, i].Value = department.Name;
                    i++;
                }
            }
        }

        private void addButton_Enter(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                context.Departments.Load();
                DbSet<Department> departments = context.Departments;
                int i = 0;
                dataGridView1.RowCount = departments.Count();

                foreach (Department department in departments)
                {
                    dataGridView1[0, i].Value = department.Id;
                    dataGridView1[1, i].Value = department.Name;
                    i++;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            MainForm form = new MainForm();
            form.Show();
        }

        private void DepartmentForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                context.Departments.Load();
                DbSet<Department> departments = context.Departments;
                int i = 0;
                dataGridView1.RowCount = departments.Count();

                foreach (Department department in departments)
                {
                    dataGridView1[0, i].Value = department.Id;
                    dataGridView1[1, i].Value = department.Name;
                    i++;
                }
            }
        }
    }
}
