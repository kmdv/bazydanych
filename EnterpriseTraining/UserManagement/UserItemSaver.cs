using System;
using System.Data.SqlClient;

using EnterpriseTraining.Entities;
using EnterpriseTraining.ListManagement;
using EnterpriseTraining.Sql;

namespace EnterpriseTraining.UserManagement
{
    public class UserItemSaver : IListItemSaver
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        private readonly IEntitySaver<User> _userSaver;

        public UserItemSaver(ISqlConnectionFactory connectionFactory, IEntitySaver<User> userSaver)
        {
            _connectionFactory = connectionFactory;
            _userSaver = userSaver;
        }

        public void SaveNew(IListItem listItem)
        {
            using (var connection = _connectionFactory.Create())
            {
                var userItem = (UserItem)listItem;

                userItem.User = _userSaver.SaveNew(connection, userItem.User);
            }
        }

        public void SaveExisting(IListItem listItem)
        {
            using (var connection = _connectionFactory.Create())
            {
                _userSaver.SaveExisting(connection, ((UserItem)listItem).User);
            }
        }
    }
}
