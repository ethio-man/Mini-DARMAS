using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Mini_DARMAS.Database
{
    public class DbHelper
    {
        private readonly string _connectionString;
        public DbHelper()
        {
            _connectionString =
                "Server=localhost;Database=MiniDARMAS_DB;Trusted_Connection=True;";
        }
        public SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }
    }
}
