using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.ListManagement;
using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemFactory<T> : IListItemFactory
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        private readonly IEntityLoader<T> _entityLoader;

        private readonly IEntityNameFactory<T> _entityNameFactory;

        public EntityItemFactory(
            ISqlConnectionFactory connectionFactory,
            IEntityLoader<T> entityLoader,
            IEntityNameFactory<T> entityNameFactory)
        {
            _connectionFactory = connectionFactory;
            _entityLoader = entityLoader;
            _entityNameFactory = entityNameFactory;
        }

        public IListItem CreateNew()
        {
            return new EntityItem<T>(_entityNameFactory);
        }

        public IList<IListItem> CreateFullList()
        {
            using (var connection = _connectionFactory.Create())
            {
                var list = new List<IListItem>();
                foreach (var entity in _entityLoader.LoadAll(connection))
                {
                    list.Add(new EntityItem<T>(_entityNameFactory) { Entity = entity });
                }

                return list;
            }
        }
    }
}
