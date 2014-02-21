using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public class SessionFactory : ISessionFactory
    {
        public string ConnectionString { get; private set; }

        public SessionFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public ISession Create()
        {
            var connection = new SqlConnection(ConnectionString);

            try
            {
                connection.Open();

                return new Session(connection);
            }
            catch
            {
                connection.Dispose();
                throw;
            }
        }
    }
}
