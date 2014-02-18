using System.Data.SqlClient;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public interface IEntityRemover
    {
        void RemoveUsers(SqlConnection connection, IEnumerable<int> ids);
    }
}
