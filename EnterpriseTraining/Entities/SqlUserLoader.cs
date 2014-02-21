using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public class SqlUserLoader : IEntityLoader<User>
    {
        private const string SelectStatement = "SELECT UserId, FirstName, LastName, BirthDate, "
            + "EmailAddress, Country, City, Street, HouseNumber, FlatNumber, PostCode FROM Users";

        private readonly IOptionalCellReader _optionalCellReader;

        public SqlUserLoader(IOptionalCellReader optionalCellReader)
        {
            _optionalCellReader = optionalCellReader;
        }

        public IList<User> LoadAll(ISession session)
        {
            using (var command = session.CreateQuery(SelectStatement))
            {
                using (var reader = command.ExecuteReader())
                {
                    var list = new List<User>();
                    while (reader.Read())
                    {
                        list.Add(ReadRow(reader));
                    }

                    return list;
                }
            }
        }

        public User ReadRow(SqlDataReader reader)
        {
            return new User
            {
                Id = reader.GetInt32(0),
                FirstName = _optionalCellReader.ReadString(reader, 1),
                LastName = _optionalCellReader.ReadString(reader, 2),
                BirthDate = reader.GetDateTime(3),
                EmailAddress = _optionalCellReader.ReadString(reader, 4),
                Country = _optionalCellReader.ReadString(reader, 5),
                City = _optionalCellReader.ReadString(reader, 6),
                Street = _optionalCellReader.ReadString(reader, 7),
                HouseNumber = _optionalCellReader.ReadInt(reader, 8),
                FlatNumber = _optionalCellReader.ReadInt(reader, 9)
            };
        }
    }
}
