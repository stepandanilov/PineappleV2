using PineappleV2.Models;
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

namespace PineappleV2.Forms.AddForms
{
    public partial class AddComputer : Form
    {
        public AddComputer()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                var newComputer = new Computer()
                {
                    Id = Convert.ToInt32(idTextBox.Text),
                    Condition = nameTextBox.Text
                };
                foreach (CPU cpu in context.Cpus)
                {
                    if (cpu.name == cpuCombobox.Text) newComputer.cpu = cpu;
                }
                foreach (HDD hdd in context.Hdds)
                {
                    if (hdd.name == comboBoxHDD.Text) newComputer.hdd = hdd;
                }
                foreach (Monitor monitor in context.Monitors)
                {
                    if (monitor.name == comboBoxMonitor.Text) newComputer.monitor = monitor;
                }
                foreach (Motherboard motherboard in context.Motherboards)
                {
                    if (motherboard.name == comboBoxMonitor.Text) newComputer.motherboard = motherboard;
                }
                foreach (Mouse mouse in context.Mouses)
                {
                    if (mouse.name == comboBoxMouse.Text) newComputer.mouse = mouse;
                }
                foreach (Printer printer in context.Printers)
                {
                    if (printer.name == comboBoxPrinter.Text) newComputer.printer = printer;
                }

                context.Computers.Add(newComputer);
                context.SaveChanges();
                Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddComputer_Load(object sender, EventArgs e)
        {
            cpuCombobox.DataSource = null;
            cpuCombobox.Items.Clear();

            comboBoxHDD.DataSource = null;
            comboBoxHDD.Items.Clear();

            comboBoxMonitor.DataSource = null;
            comboBoxMonitor.Items.Clear();

            comboBoxMotherboard.DataSource = null;
            comboBoxMotherboard.Items.Clear();

            comboBoxMouse.DataSource = null;
            comboBoxMouse.Items.Clear();

            comboBoxPrinter.DataSource = null;
            comboBoxPrinter.Items.Clear();

            using (var context = new PineappleContext())
            {
                context.Cpus.Load();
                context.Hdds.Load();
                context.Monitors.Load();
                context.Motherboards.Load();
                context.Mouses.Load();
                context.Printers.Load();


                DbSet<CPU> cpus = context.Cpus;
                DbSet<HDD> hdds = context.Hdds;
                DbSet<Monitor> monitors = context.Monitors;
                DbSet<Motherboard> motherboards = context.Motherboards;
                DbSet<Mouse> mouses = context.Mouses;
                DbSet<Printer> printers = context.Printers;

                foreach (CPU cpu in cpus)
                {
                    cpuCombobox.Items.Add(cpu.name);
                }
                foreach (HDD hdd in hdds)
                {
                    comboBoxHDD.Items.Add(hdd.name);
                }
                foreach (Monitor monitor in monitors)
                {
                    comboBoxMonitor.Items.Add(monitor.name);
                }
                foreach (Motherboard motherboard in motherboards)
                {
                    comboBoxMotherboard.Items.Add(motherboard.name);
                }
                foreach (Mouse mouse in mouses)
                {
                    comboBoxMouse.Items.Add(mouse.name);
                }
                foreach (Printer printer in printers)
                {
                    comboBoxPrinter.Items.Add(printer.name);
                }
            }
        }
    }
}
