
namespace PineappleV2.Forms
{
    partial class ComputerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.computerTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motherboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.computerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // computerTable
            // 
            this.computerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Condition,
            this.CPU,
            this.HDD,
            this.Monitor,
            this.Motherboard,
            this.Mouse,
            this.Printer});
            this.computerTable.Location = new System.Drawing.Point(12, 12);
            this.computerTable.Name = "computerTable";
            this.computerTable.Size = new System.Drawing.Size(845, 275);
            this.computerTable.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Condition";
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(863, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 45);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(864, 63);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(152, 45);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            // 
            // HDD
            // 
            this.HDD.HeaderText = "HDD";
            this.HDD.Name = "HDD";
            this.HDD.ReadOnly = true;
            // 
            // Monitor
            // 
            this.Monitor.HeaderText = "Monitor";
            this.Monitor.Name = "Monitor";
            this.Monitor.ReadOnly = true;
            // 
            // Motherboard
            // 
            this.Motherboard.HeaderText = "Motherboard";
            this.Motherboard.Name = "Motherboard";
            this.Motherboard.ReadOnly = true;
            // 
            // Mouse
            // 
            this.Mouse.HeaderText = "Mouse";
            this.Mouse.Name = "Mouse";
            this.Mouse.ReadOnly = true;
            // 
            // Printer
            // 
            this.Printer.HeaderText = "Printer";
            this.Printer.Name = "Printer";
            this.Printer.ReadOnly = true;
            // 
            // ComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 294);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.computerTable);
            this.Name = "ComputerForm";
            this.Text = "ComputerForm";
            this.Activated += new System.EventHandler(this.ComputerForm_Activated);
            this.Load += new System.EventHandler(this.ComputerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView computerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motherboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printer;
    }
}