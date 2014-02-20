using System.Data.SqlClient;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public interface IEntityRemover<T>
    {
        void Remove(SqlConnection connection, IEnumerable<T> entities);
    }
}
