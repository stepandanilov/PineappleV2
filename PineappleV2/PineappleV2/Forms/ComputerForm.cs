using PineappleV2.Forms.AddForms;
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
    public partial class ComputerForm : Form
    {
        public ComputerForm()
        {
            InitializeComponent();
        }

        private void ComputerForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                computerTable.DataSource = null;
                computerTable.Rows.Clear();
                computerTable.Refresh();

                context.Computers.Load();
                context.Cpus.Load();
                context.Hdds.Load();
                context.Monitors.Load();
                context.Motherboards.Load();
                context.Mouses.Load();
                context.Printers.Load();
                DbSet<Computer> computers = context.Computers;
                int i = 0;
                computerTable.RowCount = computers.Count();

                foreach (Computer computer in computers)
                {
                    computerTable[0, i].Value = computer.Id;
                    computerTable[1, i].Value = computer.Condition;
                    computerTable[2, i].Value = computer.cpu.name;
                    computerTable[3, i].Value = computer.hdd.name;
                    computerTable[4, i].Value = computer.monitor.name;
                    computerTable[5, i].Value = computer.motherboard.name;
                    computerTable[6, i].Value = computer.mouse.name;
                    computerTable[7, i].Value = computer.printer.name;
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
            AddComputer form = new AddComputer();
            form.ShowDialog();
        }

        private void ComputerForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                computerTable.DataSource = null;
                computerTable.Rows.Clear();
                computerTable.Refresh();

                context.Computers.Load();
                context.Cpus.Load();
                context.Hdds.Load();
                context.Monitors.Load();
                context.Motherboards.Load();
                context.Mouses.Load();
                context.Printers.Load();
                DbSet<Computer> computers = context.Computers;
                int i = 0;
                computerTable.RowCount = computers.Count();

                foreach (Computer computer in computers)
                {
                    computerTable[0, i].Value = computer.Id;
                    computerTable[1, i].Value = computer.Condition;
                    computerTable[2, i].Value = computer.cpu.name;
                    computerTable[3, i].Value = computer.hdd.name;
                    computerTable[4, i].Value = computer.monitor.name;
                    computerTable[5, i].Value = computer.motherboard.name;
                    computerTable[6, i].Value = computer.mouse.name;
                    computerTable[7, i].Value = computer.printer.name;
                    i++;
                }
            }
        }
    }
}
