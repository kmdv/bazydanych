using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public interface ISqlContext
    {
        string ConnectionString { get; }
    }
}
