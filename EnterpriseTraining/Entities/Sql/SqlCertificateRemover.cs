using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public class SqlCertificateRemover : IEntityRemover<Certificate>
    {
        private const string DeleteFormat = "DELETE FROM Certificates WHERE CertificateId IN ({0})";

        private readonly IIdListStringizer _idListStringizer;

        public SqlCertificateRemover(IIdListStringizer idListStringizer)
        {
            _idListStringizer = idListStringizer;
        }

        public void Remove(ISession session, IEnumerable<Certificate> certificates)
        {
            using (var command = session.CreateCommand(GetDeleteStatement(certificates)))
            {
                command.ExecuteNonQuery();
            }
        }

        private string GetDeleteStatement(IEnumerable<Certificate> certificates)
        {
            return string.Format(DeleteFormat, _idListStringizer.Stringize(certificates));
        }
    }
}
