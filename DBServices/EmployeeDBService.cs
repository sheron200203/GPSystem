using GPSystem.DB;
using GPSystem.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace GPSystem.DB
{
    internal class EmployeeDBService
    {

        public static void AddEmployee(Employee employee)
        {
            // Get the connection
            MySqlConnection con = dbConnection.dbconect();

            string sql = "INSERT INTO employee(firstName, lastName, monthlySalary, overtimeRate, allowance) VALUES (@FirstName, @LastName, @MonthlySalary, @OvertimeRate,@Allowance)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = employee.FirstName;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = employee.LastName;
            cmd.Parameters.Add("@MonthlySalary", MySqlDbType.Decimal).Value = employee.MonthlySalary;
            cmd.Parameters.Add("@OvertimeRate", MySqlDbType.Decimal).Value = employee.OvertimeRate;
            cmd.Parameters.Add("@Allowance", MySqlDbType.Decimal).Value = employee.Allowance;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Employee not saved. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }


        public static void UpdateEmployee(Employee employee, string id)
        {
            string sql = "UPDATE employee SET firstName = @FirstName, lastName = @LastName, monthlySalary = @MonthlySalary, overtimeRate = @OvertimeRate, allowance = @Allowance WHERE id = @ID";
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = id;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = employee.FirstName;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = employee.LastName;
            cmd.Parameters.Add("@MonthlySalary", MySqlDbType.Decimal).Value = employee.MonthlySalary;
            cmd.Parameters.Add("@OvertimeRate", MySqlDbType.Decimal).Value = employee.OvertimeRate;
            cmd.Parameters.Add("@Allowance", MySqlDbType.Decimal).Value = employee.Allowance;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Employee not updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }

        public static void DeleteEmployee(string id)
        {
            string sql = "DELETE FROM employee WHERE ID = @ID";
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Employee not deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public static List<Employee> GetEmployeeNames()
        {
            string sql = "SELECT ID,FirstName,LastName from employee";
            MySqlConnection con = dbConnection.dbconect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = null;
            List<Employee> employeeNames = new List<Employee>();
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee clientName = new Employee()
                    {
                        Id = reader.GetInt32("ID"),
                        FullName = $"{char.ToUpper(reader.GetString("FirstName")[0])}{reader.GetString("FirstName").Substring(1)} {char.ToUpper(reader.GetString("LastName")[0])}{reader.GetString("LastName").Substring(1)}",
                    };
                    employeeNames.Add(clientName);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Employee Name not inserted. \n" + ex.Message);
            }
            con.Close();

            return employeeNames;
        }
        public static Employee GetEmployeeSalary(int id)
        {
            try
            {
                // Get the connection
                MySqlConnection con = dbConnection.dbconect();
                string sql = "SELECT * FROM employee where id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                Employee employee = new Employee();

                if (!reader.Read())
                    throw new InvalidOperationException("No records were returned.");

                employee.MonthlySalary = Decimal.Parse(reader["monthlySalary"].ToString());
                employee.Allowance = Decimal.Parse(reader["allowance"].ToString());
                employee.OvertimeRate = Decimal.Parse(reader["overtimeRate"].ToString());
                return employee;
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
