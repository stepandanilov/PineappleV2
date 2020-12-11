
namespace PineappleV2.Forms.AddForms
{
    partial class AddComputer
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.closeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cpuCombobox = new System.Windows.Forms.ComboBox();
            this.comboBoxHDD = new System.Windows.Forms.ComboBox();
            this.comboBoxPrinter = new System.Windows.Forms.ComboBox();
            this.comboBoxMonitor = new System.Windows.Forms.ComboBox();
            this.comboBoxMouse = new System.Windows.Forms.ComboBox();
            this.comboBoxMotherboard = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 10;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Condition:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 22;
            label1.Text = "Monitor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 153);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 23;
            label2.Text = "Motherboard:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 13);
            label3.TabIndex = 24;
            label3.Text = "CPU:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 13);
            label4.TabIndex = 25;
            label4.Text = "HDD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 180);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 13);
            label5.TabIndex = 26;
            label5.Text = "Mouse:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(14, 207);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(40, 13);
            label6.TabIndex = 27;
            label6.Text = "Printer:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(17, 270);
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
            this.AddButton.Location = new System.Drawing.Point(156, 270);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 35);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(85, 15);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // cpuCombobox
            // 
            this.cpuCombobox.FormattingEnabled = true;
            this.cpuCombobox.Location = new System.Drawing.Point(85, 67);
            this.cpuCombobox.Name = "cpuCombobox";
            this.cpuCombobox.Size = new System.Drawing.Size(200, 21);
            this.cpuCombobox.TabIndex = 16;
            // 
            // comboBoxHDD
            // 
            this.comboBoxHDD.FormattingEnabled = true;
            this.comboBoxHDD.Location = new System.Drawing.Point(85, 94);
            this.comboBoxHDD.Name = "comboBoxHDD";
            this.comboBoxHDD.Size = new System.Drawing.Size(200, 21);
            this.comboBoxHDD.TabIndex = 17;
            // 
            // comboBoxPrinter
            // 
            this.comboBoxPrinter.FormattingEnabled = true;
            this.comboBoxPrinter.Location = new System.Drawing.Point(85, 202);
            this.comboBoxPrinter.Name = "comboBoxPrinter";
            this.comboBoxPrinter.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPrinter.TabIndex = 19;
            // 
            // comboBoxMonitor
            // 
            this.comboBoxMonitor.FormattingEnabled = true;
            this.comboBoxMonitor.Location = new System.Drawing.Point(85, 121);
            this.comboBoxMonitor.Name = "comboBoxMonitor";
            this.comboBoxMonitor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMonitor.TabIndex = 18;
            // 
            // comboBoxMouse
            // 
            this.comboBoxMouse.FormattingEnabled = true;
            this.comboBoxMouse.Location = new System.Drawing.Point(85, 175);
            this.comboBoxMouse.Name = "comboBoxMouse";
            this.comboBoxMouse.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMouse.TabIndex = 21;
            // 
            // comboBoxMotherboard
            // 
            this.comboBoxMotherboard.FormattingEnabled = true;
            this.comboBoxMotherboard.Location = new System.Drawing.Point(85, 148);
            this.comboBoxMotherboard.Name = "comboBoxMotherboard";
            this.comboBoxMotherboard.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMotherboard.TabIndex = 20;
            // 
            // AddComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 318);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBoxMouse);
            this.Controls.Add(this.comboBoxMotherboard);
            this.Controls.Add(this.comboBoxPrinter);
            this.Controls.Add(this.comboBoxMonitor);
            this.Controls.Add(this.comboBoxHDD);
            this.Controls.Add(this.cpuCombobox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddComputer";
            this.Text = "AddComputer";
            this.Load += new System.EventHandler(this.AddComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox cpuCombobox;
        private System.Windows.Forms.ComboBox comboBoxHDD;
        private System.Windows.Forms.ComboBox comboBoxPrinter;
        private System.Windows.Forms.ComboBox comboBoxMonitor;
        private System.Windows.Forms.ComboBox comboBoxMouse;
        private System.Windows.Forms.ComboBox comboBoxMotherboard;
    }
}