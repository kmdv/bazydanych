using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public class EntityRemover<T> : IEntityRemover<T>
        where T : class, IEntity
    {
        private readonly IIdListStringizer _idListStringizer;

        public string DeleteFormat { get; set; }

        public EntityRemover(IIdListStringizer idListStringizer)
        {
            _idListStringizer = idListStringizer;
        }

        public void Remove(ISession session, IEnumerable<T> entities)
        {
            using (var command = session.CreateCommand(GetDeleteStatement(entities)))
            {
                command.ExecuteNonQuery();
            }
        }

        private string GetDeleteStatement(IEnumerable<T> entities)
        {
            return string.Format(DeleteFormat, _idListStringizer.Stringize(entities));
        }

        public static EntityRemover<T> CreateForTable(
            IIdListStringizer idListStringizer,
            string tableName,
            string idColumnName)
        {
            return new EntityRemover<T>(idListStringizer)
            {
                DeleteFormat = string.Format("DELETE FROM {0} WHERE {1} IN ({{0}})", tableName, idColumnName)
            };
        }
    }
}
