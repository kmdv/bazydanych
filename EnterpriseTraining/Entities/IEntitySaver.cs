using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public interface IEntitySaver<T> 
        where T : class
    {
        void SaveNew(SqlConnection connection, T entity);

        void SaveExisting(SqlConnection connection, T entity);
    }
}
