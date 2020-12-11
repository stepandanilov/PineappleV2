namespace PineappleV2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.departmentButton = new System.Windows.Forms.Button();
            this.computerButton = new System.Windows.Forms.Button();
            this.peripheryButton = new System.Windows.Forms.Button();
            this.positionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(12, 12);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(257, 63);
            this.employeeButton.TabIndex = 0;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load test data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // departmentButton
            // 
            this.departmentButton.Location = new System.Drawing.Point(12, 81);
            this.departmentButton.Name = "departmentButton";
            this.departmentButton.Size = new System.Drawing.Size(257, 63);
            this.departmentButton.TabIndex = 3;
            this.departmentButton.Text = "Departments";
            this.departmentButton.UseVisualStyleBackColor = true;
            this.departmentButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // computerButton
            // 
            this.computerButton.Location = new System.Drawing.Point(12, 150);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(257, 63);
            this.computerButton.TabIndex = 4;
            this.computerButton.Text = "Computers";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.computerButton_Click);
            // 
            // peripheryButton
            // 
            this.peripheryButton.Location = new System.Drawing.Point(13, 219);
            this.peripheryButton.Name = "peripheryButton";
            this.peripheryButton.Size = new System.Drawing.Size(256, 63);
            this.peripheryButton.TabIndex = 5;
            this.peripheryButton.Text = "Periphery";
            this.peripheryButton.UseVisualStyleBackColor = true;
            this.peripheryButton.Click += new System.EventHandler(this.peripheryButton_Click);
            // 
            // positionButton
            // 
            this.positionButton.Location = new System.Drawing.Point(12, 288);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(256, 63);
            this.positionButton.TabIndex = 6;
            this.positionButton.Text = "Positions";
            this.positionButton.UseVisualStyleBackColor = true;
            this.positionButton.Click += new System.EventHandler(this.positionButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.positionButton);
            this.Controls.Add(this.peripheryButton);
            this.Controls.Add(this.computerButton);
            this.Controls.Add(this.departmentButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.employeeButton);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button departmentButton;
        private System.Windows.Forms.Button computerButton;
        private System.Windows.Forms.Button peripheryButton;
        private System.Windows.Forms.Button positionButton;
        private System.Windows.Forms.Button button1;
    }
}

