using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public interface IEntityLoader<T>
    {
        IList<T> LoadAll(SqlConnection connection);
    }
}
