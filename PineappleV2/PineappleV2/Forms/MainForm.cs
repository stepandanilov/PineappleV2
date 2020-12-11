using PineappleV2.Forms;
using PineappleV2.Models;
using PineappleV2.Util;
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

namespace PineappleV2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestData testdata = new TestData();
            testdata.FillDb();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestData testdata = new TestData();
            testdata.ClearData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            Hide();
            form.Show();
        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            ComputerForm form = new ComputerForm();
            Hide();
            form.Show();
        }

        private void peripheryButton_Click(object sender, EventArgs e)
        {
            PeripheryForm form = new PeripheryForm();
            Hide();
            form.Show();
        }

        private void positionButton_Click(object sender, EventArgs e)
        {
            PositionForm form = new PositionForm();
            Hide();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
