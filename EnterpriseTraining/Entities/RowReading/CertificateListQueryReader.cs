using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class CertificateListQueryReader : ICertificateListQueryReader
    {
        private readonly ICertificateRowReader _rowReader;

        public CertificateListQueryReader(ICertificateRowReader rowReader)
        {
            _rowReader = rowReader;
        }

        public IList<Certificate> Read(SqlCommand query)
        {
            using (var reader = query.ExecuteReader())
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
}
