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
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            Close();
            form.Show();

        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                PositionsTable.DataSource = null;
                PositionsTable.Rows.Clear();
                PositionsTable.Refresh();

                context.Positions.Load();
                DbSet<Position> positions = context.Positions;
                int i = 0;
                PositionsTable.RowCount = positions.Count();

                foreach (Position position in positions)
                {
                    PositionsTable[0, i].Value = position.Id;
                    PositionsTable[1, i].Value = position.Name;

                    i++;
                }
            }
        }

        private void PositionForm_Activated(object sender, EventArgs e)
        {
            using (var context = new PineappleContext())
            {
                PositionsTable.DataSource = null;
                PositionsTable.Rows.Clear();
                PositionsTable.Refresh();

                context.Positions.Load();
                DbSet<Position> positions = context.Positions;
                int i = 0;
                PositionsTable.RowCount = positions.Count();

                foreach (Position position in positions)
                {
                    PositionsTable[0, i].Value = position.Id;
                    PositionsTable[1, i].Value = position.Name;

                    i++;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PositionAddForm form = new PositionAddForm();
            form.ShowDialog();
        }
    }
}
