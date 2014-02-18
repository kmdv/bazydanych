namespace EnterpriseTraining.Sql
{
    public class DefaultSqlContext : ISqlContext
    {
        public string ConnectionString { get; private set; }

        public DefaultSqlContext(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
