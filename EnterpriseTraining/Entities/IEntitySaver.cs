using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public interface IEntitySaver<T>
    {
        T SaveNew(SqlConnection connection, T entity);

        void SaveExisting(SqlConnection connection, T entity);
    }
}
