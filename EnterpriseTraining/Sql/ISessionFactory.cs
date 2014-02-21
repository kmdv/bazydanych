using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public interface ISessionFactory
    {
        ISession Create();
    }
}
