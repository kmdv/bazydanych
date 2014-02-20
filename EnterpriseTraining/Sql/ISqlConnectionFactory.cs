using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public interface ISqlConnectionFactory
    {
        SqlConnection Create();
    }
}
