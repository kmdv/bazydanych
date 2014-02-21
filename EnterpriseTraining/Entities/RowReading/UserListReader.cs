using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class UserListReader : IEntityListReader<User>
    {
        private readonly IEntityRowReader<User> _rowReader;

        private readonly IUserCertificatesLoader _certificatesLoader;

        public UserListReader(IEntityRowReader<User> rowReader, IUserCertificatesLoader certificatesLoader)
        {
            _rowReader = rowReader;
            _certificatesLoader = certificatesLoader;
        }

        public IList<User> Read(ISession session, SqlDataReader reader)
        {
            var list = new List<User>();
            while (reader.Read())
            {
                var user = _rowReader.Read(reader);
                user.Certificates = _certificatesLoader.Load(session, user.Id);

                list.Add(user);
            }

            return list;
        }
    }
}
