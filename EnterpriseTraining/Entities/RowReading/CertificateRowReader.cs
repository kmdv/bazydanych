using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class CertificateRowReader : IEntityRowReader<Certificate>
    {
        public Certificate Read(SqlDataReader reader)
        {
            return new Certificate
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                ValidityYears = reader.GetInt32(2)
            };
        }
    }
}
