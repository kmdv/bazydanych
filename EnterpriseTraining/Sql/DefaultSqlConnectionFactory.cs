using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public class DefaultSqlConnectionFactory : ISqlConnectionFactory
    {
        public string ConnectionString { get; private set; }

        public DefaultSqlConnectionFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public SqlConnection Create()
        {
            var connection = new SqlConnection(ConnectionString);

            try
            {
                connection.Open();
                return connection;
            }
            catch
            {
                connection.Dispose();
                throw;
            }
        }
    }
}
