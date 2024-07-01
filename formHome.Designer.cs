namespace GPSystem
{
    partial class formHome
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
            btnEmployee = new Button();
            btnSetting = new Button();
            btnSalary = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(48, 147);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(155, 73);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += button1_Click;
            // 
            // btnSetting
            // 
            btnSetting.Location = new Point(611, 147);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(155, 73);
            btnSetting.TabIndex = 1;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnSalary
            // 
            btnSalary.Location = new Point(333, 147);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(155, 73);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnSalary_Click;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalary);
            Controls.Add(btnSetting);
            Controls.Add(btnEmployee);
            Name = "formHome";
            Text = "formHome";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnSetting;
        private Button btnSalary;
    }
}