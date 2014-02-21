using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface ITrainingListQueryReader
    {
        IList<Training> Read(SqlCommand query);
    }
}
