using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class UserCertificatesRemover : IEntityRemover<User>
    {
        private const string DeleteFormat = "DELETE FROM UserCertificates WHERE UserId IN ({0})";

        private readonly IIdListStringizer _idListStringizer;

        private readonly IEntityRemover<User> _decorated;

        public UserCertificatesRemover(IIdListStringizer idListStringizer, IEntityRemover<User> decorated)
        {
            _idListStringizer = idListStringizer;
            _decorated = decorated;
        }

        public void Remove(ISession session, IEnumerable<User> users)
        {
            using (var command = session.CreateCommand(GetDeleteStatement(users)))
            {
                command.ExecuteNonQuery();
            }

            _decorated.Remove(session, users);
        }

        private string GetDeleteStatement(IEnumerable<User> users)
        {
            return string.Format(DeleteFormat, _idListStringizer.Stringize(users));
        }
    }
}
