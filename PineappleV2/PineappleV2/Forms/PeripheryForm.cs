using PineappleV2.Forms.AddForms;
using PineappleV2.Forms.PeripheryForms;
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
    public partial class PeripheryForm : Form
    {
        public PeripheryForm()
        {
            InitializeComponent();
        }

        private void PeripheryForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                context.Peripheries.Load();
                DbSet<Periphery> peripheries = context.Peripheries;
                int i = 0;
                dataGridView1.RowCount = peripheries.Count();

                foreach (Periphery periphery in peripheries)
                {
                    dataGridView1[0, i].Value = periphery.Id;
                    dataGridView1[1, i].Value = periphery.Condition;
                    i++;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            MainForm form = new MainForm();
            form.Show();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddPeripheryForm form = new AddPeripheryForm();
            form.ShowDialog();
        }

        private void cpuButton_Click(object sender, EventArgs e)
        {
            CPUForm form = new CPUForm();
            Hide();
            form.Show();
        }

        private void hddButton_Click(object sender, EventArgs e)
        {
            HDDForm form = new HDDForm();
            Hide();
            form.Show();
        }

        private void monitorButton_Click(object sender, EventArgs e)
        {
            MonitorForm form = new MonitorForm();
            Hide();
            form.Show();
        }

        private void motherboardButton_Click(object sender, EventArgs e)
        {
            MotherboardForm form = new MotherboardForm();
            Hide();
            form.Show();
        }

        private void mouseButton_Click(object sender, EventArgs e)
        {
            MouseForm form = new MouseForm();
            Hide();
            form.Show();
        }

        private void printerButton_Click(object sender, EventArgs e)
        {
            PrinterForm form = new PrinterForm();
            Hide();
            form.Show();
        }
    }
}
