namespace Rabbit.Foundation.Data
{
    public interface ISqlDbWorker
    {
        /// <summary>
        /// Get database id, use to check if a database declared in the connection string is exists or not
        /// </summary>
        /// <param name="connectionString">Original connection string</param>
        int GetDatabaseId(string connectionString);

        /// <summary>
        /// Create database specified in connection string. This method should be called after GetDatabaseId
        /// </summary>
        /// <param name="connectionString">Original connection string</param>
        void CreateAssociatedDatabase(string connectionString);
    }
}