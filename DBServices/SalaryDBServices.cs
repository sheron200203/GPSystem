using GPSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSystem.DB
{
    internal class SalaryDBServices
    {
        public static void AddSalary(Salary salary)
        {
            // Get the connection
            MySqlConnection con = dbConnection.dbconect();

            string sql = "INSERT INTO salary(employeeID, month, absentDays, noOvertimeHours, noLeaves, noHolidays, basePay, noPay, grossPay) VALUES (@employeeID, @month, @absentDays, @noOvertimeHours, @noLeaves, @noHolidays, @basePay, @noPay, @grossPay)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@employeeID", MySqlDbType.Int64).Value = salary.EmployeeID;
            cmd.Parameters.Add("@month", MySqlDbType.String).Value = salary.Month;
            cmd.Parameters.Add("@absentDays", MySqlDbType.Int64).Value = salary.AbsentDay;
            cmd.Parameters.Add("@noOvertimeHours", MySqlDbType.Int64).Value = salary.NoOvertimeHours;
            cmd.Parameters.Add("@noLeaves", MySqlDbType.Int64).Value = salary.NoLeaves;
            cmd.Parameters.Add("@noHolidays", MySqlDbType.Int64).Value = salary.NoHolidays;
            cmd.Parameters.Add("@basePay", MySqlDbType.Decimal).Value = salary.BasePay;
            cmd.Parameters.Add("@noPay", MySqlDbType.Decimal).Value = salary.NoPay;
            cmd.Parameters.Add("@grossPay", MySqlDbType.Decimal).Value = salary.GrossPay;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Salary not saved. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }
        public static void UpdateSalary(Salary salary, int id)
        {
            string sql = "UPDATE salary SET employeeID = @employeeID, month = @month, absentDays = @absentDays, noOvertimeHours = @noOvertimeHours, noLeaves = @noLeaves, noHolidays = @noHolidays, basePay = @basePay, noPay = @noPay, grossPay = @grossPay WHERE id = @ID";
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = id;
            cmd.Parameters.Add("@employeeID", MySqlDbType.Int64).Value = salary.EmployeeID;
            cmd.Parameters.Add("@month", MySqlDbType.String).Value = salary.Month;
            cmd.Parameters.Add("@absentDays", MySqlDbType.Int64).Value = salary.AbsentDay;
            cmd.Parameters.Add("@noOvertimeHours", MySqlDbType.Int64).Value = salary.NoOvertimeHours;
            cmd.Parameters.Add("@noLeaves", MySqlDbType.Int64).Value = salary.NoLeaves;
            cmd.Parameters.Add("@noHolidays", MySqlDbType.Int64).Value = salary.NoHolidays;
            cmd.Parameters.Add("@basePay", MySqlDbType.Decimal).Value = salary.BasePay;
            cmd.Parameters.Add("@noPay", MySqlDbType.Decimal).Value = salary.NoPay;
            cmd.Parameters.Add("@grossPay", MySqlDbType.Decimal).Value = salary.GrossPay;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Salary not updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }
        public static void DeleteSalary(string id)
        {
            string sql = "DELETE FROM salary WHERE ID = @ID";
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Salary not deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();

        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}


