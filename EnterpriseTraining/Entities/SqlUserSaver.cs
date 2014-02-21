using System;
using System.Data;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public sealed class SqlUserSaver : IEntitySaver<User>
    {
        private const string InsertStatement =
            "INSERT INTO Users (FirstName, LastName, BirthDate, EmailAddress, Country, City, Street, HouseNumber, FlatNumber, PostCode) " +
            "VALUES (@FirstName, @LastName, @BirthDate, @EmailAddress, @Country, @City, @Street, @HouseNumber, @FlatNumber, @PostCode)" +
            "SET @Id = SCOPE_IDENTITY()";

        private const string UpdateStatement =
            "UPDATE Users SET " +
            "FirstName=@FirstName, " +
            "LastName=@LastName, " +
            "BirthDate=@BirthDate, " +
            "EmailAddress=@EmailAddress, " +
            "Country=@Country, " +
            "City=@City, " +
            "Street=@Street, " +
            "HouseNumber=@HouseNumber, " +
            "FlatNumber=@FlatNumber, " +
            "PostCode=@PostCode " +
            "WHERE UserId=@Id";

        public void SaveNew(ISession session, User user)
        {
            using (var command = session.CreateCommand(InsertStatement))
            {
                AddCommonFields(command, user);

                command.Parameters.Add("@Id", SqlDbType.Int, 0, "UserId").Direction = ParameterDirection.Output;

                EnableNullValues(command);

                command.ExecuteNonQuery();

                SetNewId(command, user);
            }
        }

        public void SaveExisting(ISession session, User user)
        {
            using (var command = session.CreateCommand(UpdateStatement))
            {
                AddCommonFields(command, user);
                
                command.Parameters.Add(new SqlParameter("@Id", user.Id));

                EnableNullValues(command);

                command.ExecuteNonQuery();
            }
        }

        private void AddCommonFields(SqlCommand command, User user)
        {
            command.Parameters.Add(new SqlParameter("@FirstName", user.FirstName));
            command.Parameters.Add(new SqlParameter("@LastName", user.LastName));
            command.Parameters.Add(new SqlParameter("@BirthDate", user.BirthDate));
            command.Parameters.Add(new SqlParameter("@EmailAddress", user.EmailAddress));
            command.Parameters.Add(new SqlParameter("@Country", user.Country));
            command.Parameters.Add(new SqlParameter("@City", user.City));
            command.Parameters.Add(new SqlParameter("@Street", user.Street));
            command.Parameters.Add(new SqlParameter("@HouseNumber", user.HouseNumber));
            command.Parameters.Add(new SqlParameter("@FlatNumber", user.FlatNumber));
            command.Parameters.Add(new SqlParameter("@PostCode", user.PostCode));
        }

        private void EnableNullValues(SqlCommand command)
        {
            foreach (SqlParameter parameter in command.Parameters)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = DBNull.Value;
                }
            }
        }

        private void SetNewId(SqlCommand command, User user)
        {
            user.Id = (int)command.Parameters["@Id"].Value;
        }
    }
}
