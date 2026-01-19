using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MiniDARMAS.Data.DbContext
{
    public class DbHelper
    {
        private readonly string _connectionString;

        public DbHelper()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["MiniDARMAS_DB"]
                .ConnectionString;
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
