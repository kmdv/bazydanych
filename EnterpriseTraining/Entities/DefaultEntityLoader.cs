using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities
{
    public class DefaultEntityLoader : IEntityLoader
    {
        public User LoadUser(SqlDataReader reader)
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
