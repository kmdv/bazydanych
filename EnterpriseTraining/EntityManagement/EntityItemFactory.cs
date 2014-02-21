using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.ItemManagement;
using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemFactory<T> : IItemFactory
        where T : class, IEntity
    {
        private readonly ISessionFactory _sessionFactory;

        private readonly IEntityLoader<T> _entityLoader;

        private readonly IEntityFactory<T> _entityFactory;

        private readonly IEntityStringizer<T> _entityNameFactory;

        public EntityItemFactory(
            ISessionFactory sessionFactory,
            IEntityLoader<T> entityLoader,
            IEntityFactory<T> entityFactory,
            IEntityStringizer<T> entityNameFactory)
        {
            _sessionFactory = sessionFactory;
            _entityLoader = entityLoader;
            _entityFactory = entityFactory;
            _entityNameFactory = entityNameFactory;
        }

        public IItem CreateNew()
        {
            return new EntityItem<T>(_entityNameFactory) { Entity = _entityFactory.CreateNew() };
        }

        public IList<IItem> CreateFullList()
        {
            using (var session = _sessionFactory.Create())
            {
                var list = new List<IItem>();
                foreach (var entity in _entityLoader.LoadAll(session))
                {
                    list.Add(new EntityItem<T>(_entityNameFactory) { Entity = entity });
                }

                return list;
            }
        }
    }
}
