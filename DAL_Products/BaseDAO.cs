using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL_Products
{
    public class BaseDAO
    {
        private string connectionString;
        public SqlConnection conn;
        public SqlCommand command;

        public BaseDAO()
        {

            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString;

            conn = new SqlConnection(connectionString);

            command = conn.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;

            openConnection();
        }

        private SqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
