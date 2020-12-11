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
    public partial class AddPeripheryForm : Form
    {
        public AddPeripheryForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                var newPeriphery = new Periphery()
                {
                    Id = Convert.ToInt32(idTextBox.Text),
                    Condition = nameTextBox.Text
                };
                context.Peripheries.Add(newPeriphery);
                context.SaveChanges();
                Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
