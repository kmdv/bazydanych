using System.Collections.Generic;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities.RowReading;

namespace EnterpriseTraining.Entities
{
    public class SqlUserLoader : IEntityLoader<User>
    {
        private const string SelectStatement = "SELECT UserId, FirstName, LastName, BirthDate, "
            + "EmailAddress, Country, City, Street, HouseNumber, FlatNumber, PostCode FROM Users";

        private readonly IUserListQueryReader _listQueryReader;

        public SqlUserLoader(IUserListQueryReader listQueryReader)
        {
            _listQueryReader = listQueryReader;
        }

        public IList<User> LoadAll(ISession session)
        {
            using (var query = session.CreateQuery(SelectStatement))
            {
                return _listQueryReader.Read(query);
            }
        }
    }
}
