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
    public partial class MotherboardForm : Form
    {
        public MotherboardForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            PeripheryForm form = new PeripheryForm();
            Close();
            form.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void MotherboardForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                MotherboardTable.DataSource = null;
                MotherboardTable.Rows.Clear();
                MotherboardTable.Refresh();

                context.Motherboards.Load();
                DbSet<Motherboard> motherboards = context.Motherboards;
                int i = 0;
                MotherboardTable.RowCount = motherboards.Count();

                foreach (Motherboard motherboard in motherboards)
                {
                    MotherboardTable[0, i].Value = motherboard.name;
                    MotherboardTable[1, i].Value = motherboard.manufacturer;

                    i++;
                }
            }
        }

        private void MotherboardForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                MotherboardTable.DataSource = null;
                MotherboardTable.Rows.Clear();
                MotherboardTable.Refresh();

                context.Motherboards.Load();
                DbSet<Motherboard> motherboards = context.Motherboards;
                int i = 0;
                MotherboardTable.RowCount = motherboards.Count();

                foreach (Motherboard motherboard in motherboards)
                {
                    MotherboardTable[0, i].Value = motherboard.name;
                    MotherboardTable[1, i].Value = motherboard.manufacturer;

                    i++;
                }
            }
        }
    }
}
