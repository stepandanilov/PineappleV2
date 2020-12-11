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
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            PeripheryForm form = new PeripheryForm();
            Close();
            form.Show();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                MonitorTable.DataSource = null;
                MonitorTable.Rows.Clear();
                MonitorTable.Refresh();

                context.Monitors.Load();
                DbSet<Monitor> monitors = context.Monitors;
                int i = 0;
                MonitorTable.RowCount = monitors.Count();

                foreach (Monitor monitor in monitors)
                {
                    MonitorTable[0, i].Value = monitor.name;
                    MonitorTable[1, i].Value = monitor.manufacturer;

                    i++;
                }
            }
        }

        private void MonitorForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                MonitorTable.DataSource = null;
                MonitorTable.Rows.Clear();
                MonitorTable.Refresh();

                context.Monitors.Load();
                DbSet<Monitor> monitors = context.Monitors;
                int i = 0;
                MonitorTable.RowCount = monitors.Count();

                foreach (Monitor monitor in monitors)
                {
                    MonitorTable[0, i].Value = monitor.name;
                    MonitorTable[1, i].Value = monitor.manufacturer;

                    i++;
                }
            }
        }
    }
}
