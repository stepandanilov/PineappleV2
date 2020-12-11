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
    public partial class PrinterForm : Form
    {
        public PrinterForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            PeripheryForm form = new PeripheryForm();
            Close();
            form.Show();
        }

        private void PrinterForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                PrinterTable.DataSource = null;
                PrinterTable.Rows.Clear();
                PrinterTable.Refresh();

                context.Printers.Load();
                DbSet<Printer> printers = context.Printers;
                int i = 0;
                PrinterTable.RowCount = printers.Count();

                foreach (Printer printer in printers)
                {
                    PrinterTable[0, i].Value = printer.name;
                    PrinterTable[1, i].Value = printer.manufacturer;

                    i++;
                }
            }
        }

        private void PrinterForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                PrinterTable.DataSource = null;
                PrinterTable.Rows.Clear();
                PrinterTable.Refresh();

                context.Printers.Load();
                DbSet<Printer> printers = context.Printers;
                int i = 0;
                PrinterTable.RowCount = printers.Count();

                foreach (Printer printer in printers)
                {
                    PrinterTable[0, i].Value = printer.name;
                    PrinterTable[1, i].Value = printer.manufacturer;

                    i++;
                }
            }
        }
    }
}
