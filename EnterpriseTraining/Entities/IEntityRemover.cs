using System.Data.SqlClient;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public interface IEntityRemover
    {
        void Remove(SqlConnection connection, IEnumerable<int> ids);
    }
}
