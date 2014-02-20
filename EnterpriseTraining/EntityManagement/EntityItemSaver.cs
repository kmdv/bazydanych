using EnterpriseTraining.Entities;
using EnterpriseTraining.ObjectManagement;
using EnterpriseTraining.Sql;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemSaver<T> : IItemSaver 
        where T : class
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        private readonly IEntitySaver<T> _entitySaver;

        public EntityItemSaver(ISqlConnectionFactory connectionFactory, IEntitySaver<T> entitySaver)
        {
            _connectionFactory = connectionFactory;
            _entitySaver = entitySaver;
        }

        public void SaveNew(IItem listItem)
        {
            using (var connection = _connectionFactory.Create())
            {
                _entitySaver.SaveNew(connection, ((EntityItem<T>)listItem).Entity);
            }
        }

        public void SaveExisting(IItem listItem)
        {
            using (var connection = _connectionFactory.Create())
            {
                _entitySaver.SaveExisting(connection, ((EntityItem<T>)listItem).Entity);
            }
        }
    }
}
