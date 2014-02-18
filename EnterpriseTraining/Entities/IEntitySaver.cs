using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public interface IEntitySaver
    {
        User SaveNewUser(SqlConnection connection, User user);

        void SaveExistingUser(SqlConnection connection, User user);
    }
}
