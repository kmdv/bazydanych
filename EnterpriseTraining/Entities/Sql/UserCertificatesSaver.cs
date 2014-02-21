using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class UserCertificatesSaver : IEntitySaver<User>
    {
        private const string DeleteOldStatement = "DELETE FROM UserCertificates WHERE UserId = @UserId";

        private const string InsertNewStatement = "INSERT INTO UserCertificates (UserId, CertificateId) VALUES (@UserId, @CertificateId)";

        private readonly IEntitySaver<User> _decorated;

        public UserCertificatesSaver(IEntitySaver<User> decorated)
        {
            _decorated = decorated;
        }

        public void SaveNew(ISession session, User user)
        {
            _decorated.SaveNew(session, user);

            UpdateUserCertificates(session, user);
        }

        public void SaveExisting(ISession session, User user)
        {
            _decorated.SaveExisting(session, user);

            UpdateUserCertificates(session, user);
        }

        private void UpdateUserCertificates(ISession session, User user)
        {
            using (var command = session.CreateCommand(DeleteOldStatement))
            {
                command.Parameters.Add(new SqlParameter("@UserId", user.Id));
                command.ExecuteNonQuery();
            }

            foreach (var certificate in user.Certificates)
            {
                using (var command = session.CreateCommand(InsertNewStatement))
                {
                    command.Parameters.Add(new SqlParameter("@UserId", user.Id));
                    command.Parameters.Add(new SqlParameter("@CertificateId", certificate.Id));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
