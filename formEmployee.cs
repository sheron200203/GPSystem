using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPSystem.DB;
using GPSystem.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;


namespace GPSystem
{
    public partial class formEmployee : Form
    {
       
        public formEmployee()
        {
            InitializeComponent();
        }

        public void Display()
        {
            EmployeeDBService.DisplayAndSearch("SELECT ID, firstName, lastName, monthlySalary, overtimeRate, allowance FROM employee", dataGridView1);
        }

        public void Clear()
        {
            txtId.Text = txtFirstName.Text = txtLastName.Text = txtMonthlySalary.Text = txtOvertimeRate.Text = txtAllowance.Text = string.Empty;
            btnSave.Text = "Save";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtFirstName.Text == string.Empty) || (txtLastName.Text == string.Empty) || (txtMonthlySalary.Text == string.Empty) || (txtOvertimeRate.Text == string.Empty) || (txtAllowance.Text == string.Empty))
            {
                MessageBox.Show("Missing required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnSave.Text == "Save")
            {
                Employee employee = new Employee(txtFirstName.Text, txtLastName.Text, decimal.Parse(txtMonthlySalary.Text.Trim()), decimal.Parse(txtOvertimeRate.Text.Trim()), decimal.Parse(txtAllowance.Text.Trim()));
                EmployeeDBService.AddEmployee(employee);
            }
            if (btnSave.Text == "Update")
            {
                Employee employee = new Employee(txtFirstName.Text, txtLastName.Text, decimal.Parse(txtMonthlySalary.Text.Trim()), decimal.Parse(txtOvertimeRate.Text.Trim()), decimal.Parse(txtAllowance.Text.Trim()));
                EmployeeDBService.UpdateEmployee(employee, txtId.Text);
            }
            Clear();
            Display();
        }

        private void formEmployee_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();
                txtMonthlySalary.Text = row.Cells[3].Value.ToString();
                txtOvertimeRate.Text = row.Cells[4].Value.ToString();
                txtAllowance.Text = row.Cells[5].Value.ToString();
                btnSave.Text = "Update";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtId.Text != string.Empty))
            {
                EmployeeDBService.DeleteEmployee(txtId.Text);
            }
            Clear();
            Display();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
