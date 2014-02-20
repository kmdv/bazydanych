using System.Collections.Generic;

using EnterpriseTraining.ListManagement;
using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.UserManagement
{
    public class UserItemRemover : IListItemRemover
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        private readonly IEntityRemover _entityRemover;

        public UserItemRemover(ISqlConnectionFactory connectionFactory, IEntityRemover entityRemover)
        {
            _connectionFactory = connectionFactory;
            _entityRemover = entityRemover;
        }

        public IListItem CreateNew()
        {
            return new UserItem();
        }
    
        public void Remove(IEnumerable<IListItem> listItems)
        {
            var ids = new List<int>();
            foreach (var listItem in listItems)
            {
                ids.Add(((UserItem)listItem).User.Id);
            }

            using (var connection = _connectionFactory.Create())
            {
                _entityRemover.Remove(connection, ids);
            }
        }
    }
}
