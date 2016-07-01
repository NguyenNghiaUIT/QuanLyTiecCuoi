using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatabaseHelper
    {
        private static SqlConnection sCon;
        public static String CONNECTION_STRING { get; set; }
        private static SqlCommand mCommand;
        /// <summary>
        /// Open connection to Database
        /// </summary>
        /// <returns></returns>
        public static bool OpenConnection()
        {
            if (sCon == null)
                sCon = new SqlConnection(CONNECTION_STRING);
            try
            {
                sCon.Open();
            }
            catch (Exception e)
            {
                sCon = null;
                return false;
            }

            return true;
        }
        /// <summary>
        /// Close Connection to Database
        /// </summary>
        public static void CloseConnection()
        {
            if (sCon != null)
            {
                sCon.Close();
            }
        }

        public static String CreateConnectionString(String datasource, String databaseName)
        {
            return "Data Source=" + datasource + ";Initial Catalog=" + databaseName + ";Integrated Security=True";
        }

        public static int ExcuteSql(String sql)
        {
            OpenConnection();
            int rowEffect = -1;
            mCommand = new SqlCommand();
            mCommand.Connection = sCon;
            mCommand.CommandText = sql;
            try
            {
                rowEffect = mCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                CloseConnection();
            }
             
            CloseConnection();
            return rowEffect;
        }

        public static DataTable GetData(String sql)
        {
            OpenConnection();
            DataTable dt = null;
            if (sCon != null)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sCon);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            CloseConnection();
            return dt;
        }

        // CheckIfExists("select * from Sanh where id = id
        public static bool CheckIfExists(string sql)
        {
            OpenConnection();
            mCommand = new SqlCommand();
            mCommand.Connection = sCon;
            mCommand.CommandText = sql;
            int rowEffect = mCommand.ExecuteNonQuery();
            CloseConnection();
            if (rowEffect > 0)
                return true;

            return false;
        }
        // CheckIfExists("select * from Sanh where id = id
        public static int CountRecord(string sql)
        {
            OpenConnection();
            mCommand = new SqlCommand();
            mCommand.Connection = sCon;
            mCommand.CommandText = sql;
            int rowEffect = (int)mCommand.ExecuteScalar();
            CloseConnection();
            return rowEffect;
        }
    }
}
