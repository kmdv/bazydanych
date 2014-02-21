using System.Collections.Generic;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities.RowReading;

namespace EnterpriseTraining.Entities
{
    public class SqlCertificateLoader : IEntityLoader<Certificate>
    {
        private const string SelectStatement = "SELECT CertificateId, Name FROM Certificates";

        private readonly ICertificateListQueryReader _listQueryReader;

        public SqlCertificateLoader(ICertificateListQueryReader listQueryReader)
        {
            _listQueryReader = listQueryReader;
        }

        public IList<Certificate> LoadAll(ISession session)
        {
            using (var query = session.CreateQuery(SelectStatement))
            {
                return _listQueryReader.Read(query);
            }
        }
    }
}
