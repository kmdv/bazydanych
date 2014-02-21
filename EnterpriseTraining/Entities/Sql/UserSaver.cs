using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class UserSaver : AbstractEntitySaver<User>
    {
        private const string CustomInsertStatement =
            "INSERT INTO Users (FirstName, LastName, BirthDate, EmailAddress, Country, City, Street, HouseNumber, FlatNumber, PostCode) " +
            "VALUES (@FirstName, @LastName, @BirthDate, @EmailAddress, @Country, @City, @Street, @HouseNumber, @FlatNumber, @PostCode)" +
            "SET @Id = SCOPE_IDENTITY()";

        private const string CustomUpdateStatement =
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

        private const string CustomIdColumnName = "UserId";

        private const string CustomIdParameterName = "@Id";

        protected override void AddCommonFields(SqlCommand command, User user)
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

        protected override string InsertStatement
        {
            get { return CustomInsertStatement; }
        }

        protected override string UpdateStatement
        {
            get { return CustomUpdateStatement; }
        }

        protected override string IdColumnName
        {
            get { return CustomIdColumnName; }
        }

        protected override string IdParameterName
        {
            get { return CustomIdParameterName; }
        }
    }
}
