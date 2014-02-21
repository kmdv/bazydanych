using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface ICertificateListQueryReader
    {
        IList<Certificate> Read(SqlCommand query);
    }
}
