using System.Collections.Generic;

using EnterpriseTraining.ItemManagement;
using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemRemover<T> : IItemRemover
        where T : class, IEntity
    {
        private readonly ISessionFactory _sessionFactory;

        private readonly IEntityRemover<T> _entityRemover;

        public EntityItemRemover(ISessionFactory sessionFactory, IEntityRemover<T> entityRemover)
        {
            _sessionFactory = sessionFactory;
            _entityRemover = entityRemover;
        }

        public void Remove(IEnumerable<IItem> item)
        {
            using (var session = _sessionFactory.Create())
            {
                _entityRemover.Remove(session, GetEntities(item));

                session.FlushChanges();
            }
        }

        private IList<T> GetEntities(IEnumerable<IItem> items)
        {
            var entities = new List<T>();
            foreach (var item in items)
            {
                entities.Add(((EntityItem<T>)item).Entity);
            }

            return entities;
        }
    }
}
