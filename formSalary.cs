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


        public void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Save")
            {
                if ((comboEmployee.Text == string.Empty) || (txtAbsent.Text == string.Empty) || (txtOvertime.Text == string.Empty) || (txtLeaves.Text == string.Empty) || (comboMonth.Text == string.Empty))
                {
                    MessageBox.Show("Missing required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SalaryFunctions salaryFunctions = new SalaryFunctions();
                Employee employee = new Employee();
                Setting setting = new Setting();
                ComboBoxItem selectedItem = (ComboBoxItem)comboEmployee.SelectedItem;
                // Retrieve the employee ID
                int employeeId = selectedItem.Id;
                employee = EmployeeDBService.getEmployeeSalary(employeeId);
                setting = SettingDBServices.getSalarySettings(comboMonth.SelectedItem.ToString());
                decimal noPay = salaryFunctions.NoPay(employee.MonthlySalary, setting.SCDRange, int.Parse(txtAbsent.Text.ToString()));
                decimal basePay = salaryFunctions.BasePay(employee.MonthlySalary, employee.Allowance, employee.OvertimeRate, decimal.Parse(txtOvertime.Text.ToString()));
                decimal grossPay = salaryFunctions.GrossPay(basePay, noPay, setting.Tax);
             

                // Round off to two decimal places
                decimal roundedBasePay = Math.Round(basePay, 2);
                decimal roundedNoPay = Math.Round(noPay, 2);
                decimal roundedGrossPay = Math.Round(grossPay, 2);


                // Display the message box with rounded values
                MessageBox.Show($"Base Pay: {roundedBasePay}\nNo Pay: {roundedNoPay}\nGross Pay: {roundedGrossPay}", "Pays", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Salary salary = new Salary(employeeId, comboMonth.SelectedItem.ToString(), int.Parse(txtAbsent.Text.Trim()), int.Parse(txtOvertime.Text.Trim()), int.Parse(txtLeaves.Text.Trim()), setting.Holiday, decimal.Parse(roundedBasePay.ToString()), decimal.Parse(roundedNoPay.ToString()), decimal.Parse(roundedGrossPay.ToString()));
                SalaryDBServices.AddSalary(salary);

            }
            if (btnSave.Text == "Update")
            {
/*                Salary salary = new Salary(employeeId, comboMonth.SelectedItem.ToString(), int.Parse(txtAbsent.Text.Trim()), int.Parse(txtOvertime.Text.Trim()), int.Parse(txtLeaves.Text.Trim()), setting.Holiday, decimal.Parse(roundedBasePay.ToString()), decimal.Parse(roundedNoPay.ToString()), decimal.Parse(roundedGrossPay.ToString()));
                SalaryDBServices.UpdateSalary(salary, txtId.Text);
*/            }
            Clear();
            Display();
        }

        private void formSalary_Load(object sender, EventArgs e)
        {
            List<Employee> employees = EmployeeDBService.GetEmployeeNames();
            comboEmployee.DataSource = employees;
            comboEmployee.DisplayMember = "FullName"; // Display the FullName property of Employee
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
    }
}
