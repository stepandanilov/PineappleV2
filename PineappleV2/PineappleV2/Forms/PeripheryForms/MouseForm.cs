using PineappleV2.Models.ComputerSettings;
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

namespace PineappleV2.Forms.PeripheryForms
{
    public partial class MouseForm : Form
    {
        public MouseForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            PeripheryForm form = new PeripheryForm();
            Close();
            form.Show();
        }

        private void MouseForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                MouseTable.DataSource = null;
                MouseTable.Rows.Clear();
                MouseTable.Refresh();

                context.Mouses.Load();
                DbSet<Mouse> mouses = context.Mouses;
                int i = 0;
                MouseTable.RowCount = mouses.Count();

                foreach (Mouse mouse in mouses)
                {
                    MouseTable[0, i].Value = mouse.name;
                    MouseTable[1, i].Value = mouse.manufacturer;

                    i++;
                }
            }
        }

        private void MouseForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                MouseTable.DataSource = null;
                MouseTable.Rows.Clear();
                MouseTable.Refresh();

                context.Mouses.Load();
                DbSet<Mouse> mouses = context.Mouses;
                int i = 0;
                MouseTable.RowCount = mouses.Count();

                foreach (Mouse mouse in mouses)
                {
                    MouseTable[0, i].Value = mouse.name;
                    MouseTable[1, i].Value = mouse.manufacturer;

                    i++;
                }
            }
        }
    }
}
