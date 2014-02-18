using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public class DefaultEntityRemover : IEntityRemover
    {
        private const string DeleteUserCommandFormat = "DELETE FROM Users WHERE UserId IN ({0})";

        public void RemoveUsers(SqlConnection connection, IEnumerable<int> ids)
        {
            var idsAsStringList = new List<string>();
            foreach (int id in ids)
            {
                idsAsStringList.Add(string.Format("{0:d}", id));
            }

            var idsAsString = string.Join(",", idsAsStringList);

            string commandText = string.Format(DeleteUserCommandFormat, idsAsString);

            using (var command = new SqlCommand(commandText, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
