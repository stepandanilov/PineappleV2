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
    public partial class PositionAddForm : Form
    {
        public PositionAddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PositionForm form = new PositionForm();
            Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                var newPosition = new Position()
                {
                    Id = Convert.ToInt32(idTextBox.Text),
                    Name = nameTextBox.Text
                };
                context.Positions.Add(newPosition);
                context.SaveChanges();
                Close();
            }
        }
    }
}
