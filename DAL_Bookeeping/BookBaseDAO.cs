using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Bookkeeping
{
    public class BaseDAL
    {
        private string connectionString;
        public SqlConnection connection;
        public SqlCommand command;

        public BaseDAL()
        {

            connectionString = ConfigurationManager.
            ConnectionStrings["ConnectionString1"].ConnectionString;

            connection = new SqlConnection(connectionString);

            command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            openConnection();
        }

        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }
    }
}

