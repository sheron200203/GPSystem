namespace GPSystem
{
    partial class formSalary
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
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            month = new Label();
            employeeID = new Label();
            comboMonth = new ComboBox();
            txtAbsent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOvertime = new TextBox();
            label3 = new Label();
            txtLeaves = new TextBox();
            comboEmployee = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 180);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 33;
            txtId.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(12, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1102, 329);
            dataGridView1.TabIndex = 30;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "employeeID";
            Column2.HeaderText = "Employee ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "month";
            Column3.HeaderText = "Month";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "absentDays";
            Column4.HeaderText = "Absent Days";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "noOvertimeHours";
            Column5.HeaderText = "No.Overtime Hours";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "noLeaves";
            Column6.HeaderText = "No. Leaves";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "noHolidays";
            Column7.HeaderText = "No. Holidays";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "basePay";
            Column8.HeaderText = "Base Pay";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.DataPropertyName = "noPay";
            Column9.HeaderText = "No Pay";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.DataPropertyName = "grossPay";
            Column10.HeaderText = "Gross Pay";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(852, 66);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(852, 101);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(852, 31);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // month
            // 
            month.AutoSize = true;
            month.Location = new Point(318, 37);
            month.Name = "month";
            month.Size = new Size(52, 20);
            month.TabIndex = 17;
            month.Text = "Month";
            // 
            // employeeID
            // 
            employeeID.AutoSize = true;
            employeeID.Location = new Point(13, 33);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(75, 20);
            employeeID.TabIndex = 35;
            employeeID.Text = "Employee";
            // 
            // comboMonth
            // 
            comboMonth.FormattingEnabled = true;
            comboMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboMonth.Location = new Point(410, 29);
            comboMonth.Name = "comboMonth";
            comboMonth.Size = new Size(125, 28);
            comboMonth.TabIndex = 41;
            comboMonth.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtAbsent
            // 
            txtAbsent.Location = new Point(105, 66);
            txtAbsent.Name = "txtAbsent";
            txtAbsent.Size = new Size(125, 27);
            txtAbsent.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 43;
            label1.Text = "Absent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 45;
            label2.Text = "Overtime";
            // 
            // txtOvertime
            // 
            txtOvertime.Location = new Point(105, 103);
            txtOvertime.Name = "txtOvertime";
            txtOvertime.Size = new Size(125, 27);
            txtOvertime.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 143);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 47;
            label3.Text = "Leaves";
            // 
            // txtLeaves
            // 
            txtLeaves.Location = new Point(105, 140);
            txtLeaves.Name = "txtLeaves";
            txtLeaves.Size = new Size(125, 27);
            txtLeaves.TabIndex = 46;
            // 
            // comboEmployee
            // 
            comboEmployee.FormattingEnabled = true;
            comboEmployee.Location = new Point(105, 25);
            comboEmployee.Name = "comboEmployee";
            comboEmployee.Size = new Size(188, 28);
            comboEmployee.TabIndex = 48;
            // 
            // formSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 594);
            Controls.Add(comboEmployee);
            Controls.Add(label3);
            Controls.Add(txtLeaves);
            Controls.Add(label2);
            Controls.Add(txtOvertime);
            Controls.Add(label1);
            Controls.Add(txtAbsent);
            Controls.Add(comboMonth);
            Controls.Add(employeeID);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(month);
            Name = "formSalary";
            Text = "formSalary";
            Load += formSalary_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label search;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtAllowance;
        private Label allowance;
        private TextBox txtOvertimeRate;
        private Label overtimeRate;
        private TextBox txtMonthlySalary;
        private Label monthlySalary;
        private TextBox txtLastName;
        private Label lastName;
        private Button btnSave;
        private TextBox txtFirstName;
        private Label month;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label employeeID;
        private ComboBox comboMonth;
        private TextBox txtAbsent;
        private Label label1;
        private Label label2;
        private TextBox txtOvertime;
        private Label label3;
        private TextBox txtLeaves;
        private ComboBox comboEmployee;
    }
}