using PineappleV2.Models.ComputerSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PineappleV2.Forms.AddForms.PeripheryAddForms
{
    public partial class AddCPUForm : Form
    {
        public AddCPUForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            using (var context = new PineappleContext())
            {
                var newCPU = new CPU()
                {
                    name = nameTextBox.Text,
                    frequency = idTextBox.Text,
                    manufacturer = textBox1.Text

                };
                context.Cpus.Add(newCPU);
                context.SaveChanges();
                Close();
            }
        }
    }
}
