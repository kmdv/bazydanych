using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public class SqlUserRemover : IEntityRemover<User>
    {
        private const string DeleteFormat = "DELETE FROM Users WHERE UserId IN ({0})";

        private readonly IIdListStringizer _idListStringizer;

        public SqlUserRemover(IIdListStringizer idListStringizer)
        {
            _idListStringizer = idListStringizer;
        }

        public void Remove(ISession session, IEnumerable<User> users)
        {
            using (var command = session.CreateCommand(GetDeleteStatement(users)))
            {
                command.ExecuteNonQuery();
            }
        }

        private string GetDeleteStatement(IEnumerable<User> users)
        {
            return string.Format(DeleteFormat, _idListStringizer.Stringize(users));
        }
    }
}
