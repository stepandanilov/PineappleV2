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
    public partial class HDDForm : Form
    {
        public HDDForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            PeripheryForm form = new PeripheryForm();
            Close();
            form.Show();
        }

        private void HDDForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                HDDTable.DataSource = null;
                HDDTable.Rows.Clear();
                HDDTable.Refresh();

                context.Hdds.Load();
                DbSet<HDD> hdds = context.Hdds;
                int i = 0;
                HDDTable.RowCount = hdds.Count();

                foreach (HDD hdd in hdds)
                {
                    HDDTable[0, i].Value = hdd.name;
                    HDDTable[1, i].Value = hdd.space;
                    HDDTable[2, i].Value = hdd.manufacturer;

                    i++;
                }
            }
        }

        private void HDDForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                HDDTable.DataSource = null;
                HDDTable.Rows.Clear();
                HDDTable.Refresh();

                context.Hdds.Load();
                DbSet<HDD> hdds = context.Hdds;
                int i = 0;
                HDDTable.RowCount = hdds.Count();

                foreach (HDD hdd in hdds)
                {
                    HDDTable[0, i].Value = hdd.name;
                    HDDTable[1, i].Value = hdd.space;
                    HDDTable[2, i].Value = hdd.manufacturer;

                    i++;
                }
            }
        }
    }
}
