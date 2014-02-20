using System.Data.SqlClient;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public class SqlUserRemover : IEntityRemover<User>
    {
        private const string IdFormat = "{0:d}";
        private const string IdSeparator = ", ";
        private const string DeleteStatementFormat = "DELETE FROM Users WHERE UserId IN ({0})";

        public void Remove(SqlConnection connection, IEnumerable<User> users)
        {
            using (var command = new SqlCommand(GetDeleteStatement(users), connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private string GetDeleteStatement(IEnumerable<User> users)
        {
            return string.Format(DeleteStatementFormat, GetIdsAsString(GetIds(users)));
        }

        private IList<int> GetIds(IEnumerable<User> users)
        {
            var ids = new List<int>();
            foreach (var user in users)
            {
                ids.Add(user.Id);
            }

            return ids;
        }

        private string GetIdsAsString(IEnumerable<int> ids)
        {
            return string.Join(IdSeparator, GetIdsAsStringList(ids));
        }

        private IList<string> GetIdsAsStringList(IEnumerable<int> ids)
        {
            var idsAsStringList = new List<string>();
            foreach (int id in ids)
            {
                idsAsStringList.Add(string.Format(IdFormat, id));
            }

            return idsAsStringList;
        }
    }
}
