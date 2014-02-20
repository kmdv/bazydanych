using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public class SqlEntityRemover : IEntityRemover
    {
        private const string IdFormat = "{0:d}";
        private const string IdSeparator = ", ";
        private const string DeleteStatementFormat = "DELETE FROM {0} WHERE {1} IN ({2})";

        private readonly string _tableName;
        private readonly string _idColumnName;

        public SqlEntityRemover(string tableName, string idColumnName)
        {
            _tableName = tableName;
            _idColumnName = idColumnName;
        }

        public void Remove(SqlConnection connection, IEnumerable<int> ids)
        {
            using (var command = new SqlCommand(GetDeleteStatement(ids), connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private string GetDeleteStatement(IEnumerable<int> ids)
        {
            return string.Format(DeleteStatementFormat, _tableName, _idColumnName, GetIdsAsString(ids));
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
