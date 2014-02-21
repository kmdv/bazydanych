using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class TrainingRowReader : IEntityRowReader<Training>
    {
        public Training Read(SqlDataReader reader)
        {
            return new Training
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Description = reader.GetString(2),
                StartDate = reader.GetDateTime(3),
                EndDate = reader.GetDateTime(4),
                Cost = reader.GetDecimal(5),
                RequiredPoints = reader.GetInt32(7),
                MaxPoints = reader.GetInt32(8)
            };
        }
    }
}
