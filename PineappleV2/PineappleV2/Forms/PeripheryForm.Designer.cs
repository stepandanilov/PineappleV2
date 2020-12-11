
namespace PineappleV2.Forms
{
    partial class PeripheryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.cpuButton = new System.Windows.Forms.Button();
            this.hddButton = new System.Windows.Forms.Button();
            this.monitorButton = new System.Windows.Forms.Button();
            this.printerButton = new System.Windows.Forms.Button();
            this.mouseButton = new System.Windows.Forms.Button();
            this.motherboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Condition});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 315);
            this.dataGridView1.TabIndex = 0;
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
            this.addButton.Location = new System.Drawing.Point(267, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 45);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(268, 64);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(133, 46);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cpuButton
            // 
            this.cpuButton.Location = new System.Drawing.Point(489, 12);
            this.cpuButton.Name = "cpuButton";
            this.cpuButton.Size = new System.Drawing.Size(133, 45);
            this.cpuButton.TabIndex = 3;
            this.cpuButton.Text = "CPUs";
            this.cpuButton.UseVisualStyleBackColor = true;
            this.cpuButton.Click += new System.EventHandler(this.cpuButton_Click);
            // 
            // hddButton
            // 
            this.hddButton.Location = new System.Drawing.Point(489, 64);
            this.hddButton.Name = "hddButton";
            this.hddButton.Size = new System.Drawing.Size(133, 47);
            this.hddButton.TabIndex = 4;
            this.hddButton.Text = "HDDs";
            this.hddButton.UseVisualStyleBackColor = true;
            this.hddButton.Click += new System.EventHandler(this.hddButton_Click);
            // 
            // monitorButton
            // 
            this.monitorButton.Location = new System.Drawing.Point(489, 117);
            this.monitorButton.Name = "monitorButton";
            this.monitorButton.Size = new System.Drawing.Size(133, 47);
            this.monitorButton.TabIndex = 5;
            this.monitorButton.Text = "Monitors";
            this.monitorButton.UseVisualStyleBackColor = true;
            this.monitorButton.Click += new System.EventHandler(this.monitorButton_Click);
            // 
            // printerButton
            // 
            this.printerButton.Location = new System.Drawing.Point(489, 275);
            this.printerButton.Name = "printerButton";
            this.printerButton.Size = new System.Drawing.Size(133, 47);
            this.printerButton.TabIndex = 8;
            this.printerButton.Text = "Printers";
            this.printerButton.UseVisualStyleBackColor = true;
            this.printerButton.Click += new System.EventHandler(this.printerButton_Click);
            // 
            // mouseButton
            // 
            this.mouseButton.Location = new System.Drawing.Point(489, 222);
            this.mouseButton.Name = "mouseButton";
            this.mouseButton.Size = new System.Drawing.Size(133, 47);
            this.mouseButton.TabIndex = 7;
            this.mouseButton.Text = "Mouses";
            this.mouseButton.UseVisualStyleBackColor = true;
            this.mouseButton.Click += new System.EventHandler(this.mouseButton_Click);
            // 
            // motherboardButton
            // 
            this.motherboardButton.Location = new System.Drawing.Point(489, 170);
            this.motherboardButton.Name = "motherboardButton";
            this.motherboardButton.Size = new System.Drawing.Size(133, 45);
            this.motherboardButton.TabIndex = 6;
            this.motherboardButton.Text = "Motherboards";
            this.motherboardButton.UseVisualStyleBackColor = true;
            this.motherboardButton.Click += new System.EventHandler(this.motherboardButton_Click);
            // 
            // PeripheryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 334);
            this.Controls.Add(this.printerButton);
            this.Controls.Add(this.mouseButton);
            this.Controls.Add(this.motherboardButton);
            this.Controls.Add(this.monitorButton);
            this.Controls.Add(this.hddButton);
            this.Controls.Add(this.cpuButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PeripheryForm";
            this.Text = "Periphery";
            this.Load += new System.EventHandler(this.PeripheryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button cpuButton;
        private System.Windows.Forms.Button hddButton;
        private System.Windows.Forms.Button monitorButton;
        private System.Windows.Forms.Button printerButton;
        private System.Windows.Forms.Button mouseButton;
        private System.Windows.Forms.Button motherboardButton;
    }
}