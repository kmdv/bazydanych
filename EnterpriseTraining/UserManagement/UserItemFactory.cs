using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.ListManagement;
using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.UserManagement
{
    public class UserItemFactory : IListItemFactory
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        private readonly IEntityLoader<User> _userLoader;

        public UserItemFactory(ISqlConnectionFactory connectionFactory, IEntityLoader<User> userLoader)
        {
            _connectionFactory = connectionFactory;
            _userLoader = userLoader;
        }

        public IListItem CreateNew()
        {
            return new UserItem();
        }

        public IList<IListItem> CreateFullList()
        {
            using (var connection = _connectionFactory.Create())
            {
                var list = new List<IListItem>();
                foreach (var user in _userLoader.LoadAll(connection))
                {
                    list.Add(new UserItem { User = user });
                }

                return list;
            }
        }
    }
}
