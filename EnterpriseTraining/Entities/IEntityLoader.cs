using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public interface IEntityLoader<T>
        where T : class
    {
        IList<T> LoadAll(SqlConnection connection);
    }
}
