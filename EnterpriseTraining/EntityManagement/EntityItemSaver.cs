using EnterpriseTraining.Entities;
using EnterpriseTraining.ObjectManagement;
using EnterpriseTraining.Sql;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemSaver<T> : IItemSaver
        where T : class, IEntity
    {
        private readonly ISessionFactory _sessionFactory;

        private readonly IEntitySaver<T> _entitySaver;

        public EntityItemSaver(ISessionFactory sessionFactory, IEntitySaver<T> entitySaver)
        {
            _sessionFactory = sessionFactory;
            _entitySaver = entitySaver;
        }

        public void SaveNew(IItem item)
        {
            using (var session = _sessionFactory.Create())
            {
                _entitySaver.SaveNew(session, ((EntityItem<T>)item).Entity);

                session.FlushChanges();
            }
        }

        public void SaveExisting(IItem item)
        {
            using (var session = _sessionFactory.Create())
            {
                _entitySaver.SaveExisting(session, ((EntityItem<T>)item).Entity);

                session.FlushChanges();
            }
        }
    }
}
