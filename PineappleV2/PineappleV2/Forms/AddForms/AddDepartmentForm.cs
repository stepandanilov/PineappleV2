using PineappleV2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PineappleV2.Forms.AddForms
{
    public partial class AddDepartmentForm : Form
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                var newDepartment = new Department()
                {
                    Id = Convert.ToInt32(idTextBox.Text),
                    Name = nameTextBox.Text
                };
                context.Departments.Add(newDepartment);
                context.SaveChanges();
                Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddDepartmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
