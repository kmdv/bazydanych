using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface IEntityRowReader<T>
        where T : class, IEntity
    {
        T Read(SqlDataReader reader);
    }
}
