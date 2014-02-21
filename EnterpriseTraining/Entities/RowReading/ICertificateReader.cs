using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface ICertificateRowReader
    {
        Certificate Read(SqlDataReader reader);
    }
}
