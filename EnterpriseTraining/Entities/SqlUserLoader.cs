using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public class SqlUserLoader : IEntityLoader<User>
    {
        private const string SelectStatement = "SELECT * FROM Users";

        public IList<User> LoadAll(SqlConnection connection)
        {
            using (var command = new SqlCommand(SelectStatement, connection))
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
                FirstName = LoadOptionalString(reader, 1),
                LastName = LoadOptionalString(reader, 2),
                BirthDate = reader.GetDateTime(3),
                EmailAddress = LoadOptionalString(reader, 4),
                Country = LoadOptionalString(reader, 5),
                City = LoadOptionalString(reader, 6),
                Street = LoadOptionalString(reader, 7),
                HouseNumber = LoadOptionalInt(reader, 8),
                FlatNumber = LoadOptionalInt(reader, 9)
            }; 
        }

        private string LoadOptionalString(SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null : reader.GetString(index);
        }

        private int? LoadOptionalInt(SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null as int? : reader.GetInt32(index);
        }
    }
}
