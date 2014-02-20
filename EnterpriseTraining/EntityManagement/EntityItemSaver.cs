using EnterpriseTraining.Entities;
using EnterpriseTraining.ListManagement;
using EnterpriseTraining.Sql;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemSaver<T> : IListItemSaver 
        where T : class
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        private readonly IEntitySaver<T> _entitySaver;

        public EntityItemSaver(ISqlConnectionFactory connectionFactory, IEntitySaver<T> entitySaver)
        {
            _connectionFactory = connectionFactory;
            _entitySaver = entitySaver;
        }

        public void SaveNew(IListItem listItem)
        {
            using (var connection = _connectionFactory.Create())
            {
                _entitySaver.SaveNew(connection, ((EntityItem<T>)listItem).Entity);
            }
        }

        public void SaveExisting(IListItem listItem)
        {
            using (var connection = _connectionFactory.Create())
            {
                _entitySaver.SaveExisting(connection, ((EntityItem<T>)listItem).Entity);
            }
        }
    }
}
