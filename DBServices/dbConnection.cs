using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GPSystem.DB
{
    internal class dbConnection
    {
        /*public string dbconect()
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;database=gpsystem";
            return conn;
        }*/
        public static MySqlConnection dbconect()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gpsystem";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }
    }
}
