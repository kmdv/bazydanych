using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface IEntityListReader<T>
        where T : class, IEntity
    {
        IList<T> Read(ISession session, SqlDataReader reader);
    }
}
