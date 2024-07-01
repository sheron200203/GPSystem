using GPSystem.CLASSES;
using GPSystem.DB;
using GPSystem.Models;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GPSystem
{
    public partial class formSalary : Form
    {
        public formSalary()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            SalaryDBServices.DisplayAndSearch("SELECT employeeID, month, absentDays, noOvertimeHours, noLeaves, noHolidays, basePay, noPay, grossPay FROM salary", dataGridView1);
        }

        public void Clear()
        {
            comboEmployee.Text = comboMonth.Text = txtAbsent.Text = txtOvertime.Text = txtLeaves.Text = string.Empty;
            btnSave.Text = "Save";
        }

        private bool IsAnyFieldEmpty()
        {
            return string.IsNullOrEmpty(comboEmployee.Text) ||
                   string.IsNullOrEmpty(txtAbsent.Text) ||
                   string.IsNullOrEmpty(txtOvertime.Text) ||
                   string.IsNullOrEmpty(txtLeaves.Text) ||
                   string.IsNullOrEmpty(comboMonth.Text);
        }

        private int GetSelectedEmployeeId()
        {
            Employee selectedEmployee = (Employee)comboEmployee.SelectedItem;
            return selectedEmployee.Id;

        }

        private Salary CalculateAndCreateSalary(int employeeId, string selectedMonth)
        {
            Employee employee = EmployeeDBService.GetEmployeeSalary(employeeId);
            Setting setting = SettingDBServices.GetSalarySettings(selectedMonth);

            SalaryFunctions salaryFunctions = new SalaryFunctions(employee.MonthlySalary);
            int absentDays = int.Parse(txtAbsent.Text.Trim());
            decimal overtimeHours = decimal.Parse(txtOvertime.Text.Trim());

            decimal noPay = salaryFunctions.CalculateNoPay(setting.SCDRange, absentDays);
            decimal basePay = salaryFunctions.CalculateBasePay(employee.Allowance, employee.OvertimeRate, overtimeHours);
            decimal grossPay = salaryFunctions.CalculateGrossPay(basePay, noPay, setting.Tax);

            decimal roundedBasePay = Math.Round(basePay, 2);
            decimal roundedNoPay = Math.Round(noPay, 2);
            decimal roundedGrossPay = Math.Round(grossPay, 2);

            MessageBox.Show($"Base Pay: {roundedBasePay}\nNo Pay: {roundedNoPay}\nGross Pay: {roundedGrossPay}", "Pays", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return new Salary(employeeId, selectedMonth, absentDays, (int)overtimeHours, int.Parse(txtLeaves.Text.Trim()), setting.Holiday, roundedBasePay, roundedNoPay, roundedGrossPay);
        }

        private void SaveSalary(int employeeId, string selectedMonth)
        {
            Salary salary = CalculateAndCreateSalary(employeeId, selectedMonth);
            SalaryDBServices.AddSalary(salary);
        }

        private void UpdateSalary(int employeeId, string selectedMonth)
        {
            Salary salary = CalculateAndCreateSalary(employeeId, selectedMonth);
            SalaryDBServices.UpdateSalary(salary, employeeId);
        }


        public void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAnyFieldEmpty())
            {
                MessageBox.Show("Missing required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int employeeId = GetSelectedEmployeeId();
            string selectedMonth = comboMonth.SelectedItem.ToString();

            if (btnSave.Text == "Save")
            {
                SaveSalary(employeeId, selectedMonth);
            }
            else if (btnSave.Text == "Update")
            {
                UpdateSalary(employeeId, selectedMonth);
            }

            Clear();
            Display();
        }

        private void formSalary_Load(object sender, EventArgs e)
        {
            List<Employee> employees = EmployeeDBService.GetEmployeeNames();
            comboEmployee.DataSource = employees;
            comboEmployee.DisplayMember = "FullName";
            comboEmployee.ValueMember = "Id";
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtId.Text != string.Empty))
            {
                SalaryDBServices.DeleteSalary(txtId.Text);
            }
            Clear();
            Display();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtAbsent.Text = row.Cells[3].Value.ToString();
                txtOvertime.Text = row.Cells[4].Value.ToString();
                txtLeaves.Text = row.Cells[5].Value.ToString();

                // Set comboEmployee manually
                string employeeID = row.Cells[1].Value.ToString();
                foreach (Employee item in comboEmployee.Items)
                {
                    if (item.Id.ToString() == employeeID)
                    {
                        comboEmployee.SelectedItem = item;
                        break;
                    }
                }

                // Set comboMonth manually
                string month = row.Cells[2].Value.ToString();
                foreach (string item in comboMonth.Items)
                {
                    if (item == month)
                    {
                        comboMonth.SelectedItem = item;
                        break;
                    }
                }
                btnSave.Text = "Update";
            }
        }
    }
}
