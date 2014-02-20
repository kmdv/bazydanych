using System.Collections.Generic;

using EnterpriseTraining.ListManagement;
using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemRemover<T> : IListItemRemover
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        private readonly IEntityRemover<T> _entityRemover;

        public EntityItemRemover(ISqlConnectionFactory connectionFactory, IEntityRemover<T> entityRemover)
        {
            _connectionFactory = connectionFactory;
            _entityRemover = entityRemover;
        }

        public void Remove(IEnumerable<IListItem> listItems)
        {
            using (var connection = _connectionFactory.Create())
            {
                _entityRemover.Remove(connection, GetEntities(listItems));
            }
        }

        private IList<T> GetEntities(IEnumerable<IListItem> listItems)
        {
            var entities = new List<T>();
            foreach (var listItem in listItems)
            {
                entities.Add(((EntityItem<T>)listItem).Entity);
            }

            return entities;
        }
    }
}
