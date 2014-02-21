using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class UserRowReader : IEntityRowReader<User>
    {
        private readonly IOptionalCellReader _optionalCellReader;

        public UserRowReader(IOptionalCellReader optionalCellReader)
        {
            _optionalCellReader = optionalCellReader;
        }

        public User Read(SqlDataReader reader)
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
                FlatNumber = _optionalCellReader.ReadInt(reader, 9),
                PostCode = reader.GetString(10)
            };
        }
    }
}
