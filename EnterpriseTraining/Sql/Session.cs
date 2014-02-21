using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public sealed class Session : ISession
    {
        private SqlConnection _connection;

        private SqlTransaction _transaction;

        public Session(SqlConnection connection)
        {
            _connection = connection;
        }

        public SqlCommand CreateQuery()
        {
            return CreateQuery(string.Empty);
        }

        public SqlCommand CreateQuery(string queryText)
        {
            return new SqlCommand(queryText, _connection);
        }

        public SqlCommand CreateCommand()
        {
            return CreateCommand(string.Empty);
        }

        public SqlCommand CreateCommand(string commandText)
        {
            if (_transaction == null)
            {
                _transaction = _connection.BeginTransaction();
            }

            return new SqlCommand(commandText, _connection, _transaction);
        }

        public void FlushChanges()
        {
            try
            {
                if (_transaction != null)
                {
                    _transaction.Commit();
                }
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }
            }
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }

            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }
    }
}
