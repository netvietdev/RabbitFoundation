using System;
using System.Data.SqlClient;

namespace Rabbit.Foundation.Data
{
    public class SqlServerDbWorker
    {
        /// <summary>
        /// Check if a database declared in the connection string is exists or not
        /// </summary>
        /// <param name="connectionString">Original connection string</param>
        public bool CheckIfDbExists(string connectionString)
        {
            var infos = ParseConnectionString(connectionString);
            var databaseName = infos.Item1;
            var connectionStringNoDb = infos.Item2;

            using (var connection = new SqlConnection(connectionStringNoDb))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select db_id('" + databaseName + "')";

                    connection.Open();
                    var result = command.ExecuteScalar();

                    return !(result is DBNull);
                }
            }
        }

        /// <summary>
        /// Create database specified in connection string. This method should be called after CheckIfDbExists.
        /// </summary>
        /// <param name="connectionString">Original connection string</param>
        public void CreateAssociatedDatabase(string connectionString)
        {
            var infos = ParseConnectionString(connectionString);
            var databaseName = infos.Item1;
            var connectionStringNoDb = infos.Item2;

            using (var connection = new SqlConnection(connectionStringNoDb))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "CREATE DATABASE [" + databaseName + "]";

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Parse a full connection string and return DatabaseName in Item1, the new connection string without database in Item2
        /// </summary>
        /// <param name="connectionString">Original connection string</param>
        private Tuple<string, string> ParseConnectionString(string connectionString)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            var databaseName = builder.InitialCatalog;

            return new Tuple<string, string>(databaseName, builder.ConnectionString);
        }
    }
}
