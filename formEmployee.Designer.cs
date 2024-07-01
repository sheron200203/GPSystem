namespace GPSystem
{
    partial class formEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstName = new Label();
            txtFirstName = new TextBox();
            btnSave = new Button();
            txtLastName = new TextBox();
            lastName = new Label();
            txtMonthlySalary = new TextBox();
            monthlySalary = new Label();
            txtOvertimeRate = new TextBox();
            overtimeRate = new Label();
            txtAllowance = new TextBox();
            allowance = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            search = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(41, 45);
            firstName.Name = "firstName";
            firstName.Size = new Size(80, 20);
            firstName.TabIndex = 0;
            firstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(126, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(858, 39);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(126, 75);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 4;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(41, 78);
            lastName.Name = "lastName";
            lastName.Size = new Size(79, 20);
            lastName.TabIndex = 3;
            lastName.Text = "Last Name";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.Location = new Point(384, 39);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(125, 27);
            txtMonthlySalary.TabIndex = 6;
            // 
            // monthlySalary
            // 
            monthlySalary.AutoSize = true;
            monthlySalary.Location = new Point(271, 45);
            monthlySalary.Name = "monthlySalary";
            monthlySalary.Size = new Size(107, 20);
            monthlySalary.TabIndex = 5;
            monthlySalary.Text = "Monthly Salary";
            // 
            // txtOvertimeRate
            // 
            txtOvertimeRate.Location = new Point(384, 72);
            txtOvertimeRate.Name = "txtOvertimeRate";
            txtOvertimeRate.Size = new Size(125, 27);
            txtOvertimeRate.TabIndex = 8;
            // 
            // overtimeRate
            // 
            overtimeRate.AutoSize = true;
            overtimeRate.Location = new Point(274, 78);
            overtimeRate.Name = "overtimeRate";
            overtimeRate.Size = new Size(104, 20);
            overtimeRate.TabIndex = 7;
            overtimeRate.Text = "Overtime Rate";
            // 
            // txtAllowance
            // 
            txtAllowance.Location = new Point(384, 105);
            txtAllowance.Name = "txtAllowance";
            txtAllowance.Size = new Size(125, 27);
            txtAllowance.TabIndex = 10;
            // 
            // allowance
            // 
            allowance.AutoSize = true;
            allowance.Location = new Point(300, 111);
            allowance.Name = "allowance";
            allowance.Size = new Size(78, 20);
            allowance.TabIndex = 9;
            allowance.Text = "Allowance";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(858, 109);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(858, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(30, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(976, 329);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "firstName";
            Column2.HeaderText = "First Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "lastName";
            Column3.HeaderText = "Last Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "monthlySalary";
            Column4.HeaderText = "Monthly Salary";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.DataPropertyName = "overtimeRate";
            Column5.HeaderText = "Overtime Rate";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.DataPropertyName = "allowance";
            Column6.HeaderText = "Allowance";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(626, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(195, 27);
            txtSearch.TabIndex = 14;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Location = new Point(567, 19);
            search.Name = "search";
            search.Size = new Size(53, 20);
            search.TabIndex = 15;
            search.Text = "Search";
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 111);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 16;
            txtId.Visible = false;
            // 
            // formEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 523);
            Controls.Add(txtId);
            Controls.Add(search);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(txtAllowance);
            Controls.Add(allowance);
            Controls.Add(txtOvertimeRate);
            Controls.Add(overtimeRate);
            Controls.Add(txtMonthlySalary);
            Controls.Add(monthlySalary);
            Controls.Add(txtLastName);
            Controls.Add(lastName);
            Controls.Add(btnSave);
            Controls.Add(txtFirstName);
            Controls.Add(firstName);
            Name = "formEmployee";
            Text = "Form1";
            Load += formEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstName;
        private TextBox txtFirstName;
        private Button btnSave;
        private TextBox txtLastName;
        private Label lastName;
        private TextBox txtMonthlySalary;
        private Label monthlySalary;
        private TextBox txtOvertimeRate;
        private Label overtimeRate;
        private TextBox txtAllowance;
        private Label allowance;
        private Button btnCancel;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Label search;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox txtId;
    }
}
