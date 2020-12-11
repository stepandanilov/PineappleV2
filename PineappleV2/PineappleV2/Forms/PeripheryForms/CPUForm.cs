using PineappleV2.Forms.AddForms.PeripheryAddForms;
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
    public partial class CPUForm : Form
    {
        public CPUForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            PeripheryForm form = new PeripheryForm();
            Close();
            form.Show();

        }

        private void CPUForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                CPUTable.DataSource = null;
                CPUTable.Rows.Clear();
                CPUTable.Refresh();

                context.Cpus.Load();
                DbSet<CPU> cpus = context.Cpus;
                int i = 0;
                CPUTable.RowCount = cpus.Count();

                foreach (CPU cpu in cpus)
                {
                    CPUTable[0, i].Value = cpu.Id;
                    CPUTable[1, i].Value = cpu.name;
                    CPUTable[2, i].Value = cpu.frequency;
                    CPUTable[3, i].Value = cpu.manufacturer;
                    
                    i++;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCPUForm form = new AddCPUForm();
            form.ShowDialog();
        }

        private void CPUForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                CPUTable.DataSource = null;
                CPUTable.Rows.Clear();
                CPUTable.Refresh();

                context.Cpus.Load();
                DbSet<CPU> cpus = context.Cpus;
                int i = 0;
                CPUTable.RowCount = cpus.Count();

                foreach (CPU cpu in cpus)
                {
                    CPUTable[0, i].Value = cpu.Id;
                    CPUTable[1, i].Value = cpu.name;
                    CPUTable[2, i].Value = cpu.frequency;
                    CPUTable[3, i].Value = cpu.manufacturer;

                    i++;
                }
            }
        }
    }
}
