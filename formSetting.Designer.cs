namespace GPSystem
{
    partial class formSetting
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
            btnDelete = new Button();
            btnCancel = new Button();
            txtTax = new TextBox();
            tax = new Label();
            txtLeaves = new TextBox();
            leaves = new Label();
            txtscDateRange = new TextBox();
            scDateRange = new Label();
            lastName = new Label();
            btnSave = new Button();
            firstName = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label1 = new Label();
            Holidays = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtHolidays = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(110, 139);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 33;
            txtId.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(14, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(976, 329);
            dataGridView1.TabIndex = 30;
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
            Column2.DataPropertyName = "month";
            Column2.HeaderText = "Month";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "beginDate";
            Column3.HeaderText = "Begin Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "endDate";
            Column4.HeaderText = "End Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "salaryCycleDateRange";
            Column5.HeaderText = "SCD Range";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "leaves";
            Column6.HeaderText = "Leaves";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "tax";
            Column7.HeaderText = "Tax";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "holidays";
            Column8.HeaderText = "Holidays";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(874, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(874, 104);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(568, 100);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 27;
            // 
            // tax
            // 
            tax.AutoSize = true;
            tax.Location = new Point(533, 107);
            tax.Name = "tax";
            tax.Size = new Size(30, 20);
            tax.TabIndex = 26;
            tax.Text = "Tax";
            // 
            // txtLeaves
            // 
            txtLeaves.Location = new Point(568, 67);
            txtLeaves.Name = "txtLeaves";
            txtLeaves.Size = new Size(125, 27);
            txtLeaves.TabIndex = 25;
            // 
            // leaves
            // 
            leaves.AutoSize = true;
            leaves.Location = new Point(441, 72);
            leaves.Name = "leaves";
            leaves.Size = new Size(121, 20);
            leaves.TabIndex = 24;
            leaves.Text = "Permitted Leaves";
            // 
            // txtscDateRange
            // 
            txtscDateRange.Location = new Point(568, 34);
            txtscDateRange.Name = "txtscDateRange";
            txtscDateRange.Size = new Size(125, 27);
            txtscDateRange.TabIndex = 23;
            // 
            // scDateRange
            // 
            scDateRange.AutoSize = true;
            scDateRange.Location = new Point(393, 41);
            scDateRange.Name = "scDateRange";
            scDateRange.Size = new Size(170, 20);
            scDateRange.TabIndex = 22;
            scDateRange.Text = "Salary Cycle Date Range";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(20, 106);
            lastName.Name = "lastName";
            lastName.Size = new Size(78, 20);
            lastName.TabIndex = 20;
            lastName.Text = "End Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(874, 34);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(15, 73);
            firstName.Name = "firstName";
            firstName.Size = new Size(83, 20);
            firstName.TabIndex = 17;
            firstName.Text = "Begin Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(110, 75);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(110, 108);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(125, 27);
            dateTimePicker3.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 43);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 37;
            label1.Text = "Month";
            // 
            // Holidays
            // 
            Holidays.AutoSize = true;
            Holidays.Location = new Point(502, 144);
            Holidays.Name = "Holidays";
            Holidays.Size = new Size(67, 20);
            Holidays.TabIndex = 38;
            Holidays.Text = "Holidays";
            // 
            // txtHolidays
            // 
            txtHolidays.Location = new Point(568, 144);
            txtHolidays.Name = "txtHolidays";
            txtHolidays.Size = new Size(125, 27);
            txtHolidays.TabIndex = 39;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox1.Location = new Point(110, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 40;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // formSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 552);
            Controls.Add(comboBox1);
            Controls.Add(txtHolidays);
            Controls.Add(Holidays);
            Controls.Add(label1);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(txtTax);
            Controls.Add(tax);
            Controls.Add(txtLeaves);
            Controls.Add(leaves);
            Controls.Add(txtscDateRange);
            Controls.Add(scDateRange);
            Controls.Add(lastName);
            Controls.Add(btnSave);
            Controls.Add(firstName);
            Name = "formSetting";
            Text = "formSetting";
            Load += formSetting_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtTax;
        private Label tax;
        private TextBox txtLeaves;
        private Label leaves;
        private TextBox txtscDateRange;
        private Label scDateRange;
        private Label lastName;
        private Button btnSave;
        private Label firstName;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label1;
/*        private TextBox txtHoliday;
*/        private Label Holidays;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtHolidays;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox comboBox1;
    }
}