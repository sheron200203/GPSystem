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
    internal class SettingDBServices
    {
        public static void AddSetting(Setting setting)
        {
            // Get the connection
            MySqlConnection con = dbConnection.dbconect();

            string sql = "INSERT INTO setting(month, beginDate, endDate, salaryCycleDateRange, leaves, tax, holidays) VALUES (@month, @beginDate, @endDate, @salaryCycleDateRange, @leaves, @tax, @holidays)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@month", MySqlDbType.String).Value = setting.Month;
            cmd.Parameters.Add("@beginDate", MySqlDbType.Date).Value = setting.BeginDate;
            cmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = setting.EndDate;
            cmd.Parameters.Add("@salaryCycleDateRange", MySqlDbType.Int64).Value = setting.SCDRange;
            cmd.Parameters.Add("@leaves", MySqlDbType.Int64).Value = setting.Leaves;
            cmd.Parameters.Add("@tax", MySqlDbType.Decimal).Value = setting.Tax;
            cmd.Parameters.Add("@holidays", MySqlDbType.Int64).Value = setting.Holiday;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Setting saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Setting not saved. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }
        public static void UpdateSetting(Setting setting, string id)
        {
            string sql = "UPDATE setting SET month = @month, beginDate = @beginDate, endDate = @endDate, salaryCycleDateRange = @salaryCycleDateRange, leaves = @leaves, tax = @tax, holidays = @holidays WHERE id = @ID";
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = id;
            cmd.Parameters.Add("@month", MySqlDbType.String).Value = setting.Month;
            cmd.Parameters.Add("@beginDate", MySqlDbType.Date).Value = setting.BeginDate;
            cmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = setting.EndDate;
            cmd.Parameters.Add("@salaryCycleDateRange", MySqlDbType.Int64).Value = setting.SCDRange;
            cmd.Parameters.Add("@leaves", MySqlDbType.Int64).Value = setting.Leaves;
            cmd.Parameters.Add("@tax", MySqlDbType.Decimal).Value = setting.Tax;
            cmd.Parameters.Add("@holidays", MySqlDbType.Int64).Value = setting.Holiday;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Setting Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Setting not updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }
        public static void DeleteSetting(string id)
        {
            string sql = "DELETE FROM setting WHERE ID = @ID";
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Setting Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Setting not deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public static Setting GetSalarySettings(String month)
        {
            try
            {
                // Get the connection
                MySqlConnection con = dbConnection.dbconect();
                string sql = "SELECT salaryCycleDateRange,tax,holidays FROM setting where month='" + month + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                Setting setting = new Setting();

                if (!reader.Read())
                    throw new InvalidOperationException("No records were returned.");

                setting.SCDRange = int.Parse(reader["salaryCycleDateRange"].ToString());
                setting.Tax = Decimal.Parse(reader["tax"].ToString());
                setting.Holiday  = int.Parse(reader["holidays"].ToString());
                return setting;
            }
            catch (MySqlException er)
            {
                // MySQL Server will throw an error.
                Console.WriteLine("Error, " + er.Message);
                return null;
            }
        }
    }
    

}
