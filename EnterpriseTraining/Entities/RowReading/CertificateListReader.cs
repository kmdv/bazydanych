using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class CertificateListReader : IEntityListReader<Certificate>
    {
        private readonly IEntityRowReader<Certificate> _rowReader;

        public CertificateListReader(IEntityRowReader<Certificate> rowReader)
        {
            _rowReader = rowReader;
        }

        public IList<Certificate> Read(ISession session, SqlDataReader reader)
        {
            var list = new List<Certificate>();
            while (reader.Read())
            {
                list.Add(_rowReader.Read(reader));
            }

            return list;
        }
    }
}
