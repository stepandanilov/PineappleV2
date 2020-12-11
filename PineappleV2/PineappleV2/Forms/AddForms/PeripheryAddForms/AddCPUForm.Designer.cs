namespace PineappleV2.Forms.AddForms.PeripheryAddForms
{
    partial class AddCPUForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            this.closeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(60, 13);
            idLabel.TabIndex = 10;
            idLabel.Text = "Frequency:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(15, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 13);
            label1.TabIndex = 16;
            label1.Text = "Manufacturer:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(18, 130);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(133, 35);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(188, 130);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 35);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(117, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 17;
            // 
            // AddCPUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 178);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddCPUForm";
            this.Text = "AddCPUForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}