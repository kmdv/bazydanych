using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EnterpriseTraining.Sql;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public class UserCertificatesLoader : EnterpriseTraining.Entities.RowReading.IUserCertificatesLoader
    {
        private const string SelectStatement =
            "SELECT C.CertificateId, Name FROM Certificates C " +
            "INNER JOIN UserCertificates UC ON UC.CertificateId = C.CertificateId " +
            "WHERE UC.UserId = @UserId";

        private readonly CertificateListReader _certificateListReader;

        public UserCertificatesLoader(CertificateListReader certificateListReader)
        {
            _certificateListReader = certificateListReader;
        }

        public IList<Certificate> Load(ISession session, int userId)
        {
            using (var query = session.CreateQuery(SelectStatement))
            {
                query.Parameters.Add(new SqlParameter("@UserId", userId));
                return _certificateListReader.Read(session, query.ExecuteReader());
            }
        }
    }
}
