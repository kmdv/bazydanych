using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public interface IEntityLoader
    {
        User LoadUser(SqlDataReader reader);
    }
}
