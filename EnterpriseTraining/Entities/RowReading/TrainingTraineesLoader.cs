using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public class TrainingTraineesLoader : ITrainingTraineesLoader
    {
        private const string SelectStatement =
            "SELECT U.UserId, FirstName, LastName, BirthDate, EmailAddress, Country, " +
                "City, Street, HouseNumber, FlatNumber, PostCode FROM Users U " +
            "INNER JOIN Trainees T ON T.UserId = U.UserId " +
            "WHERE T.TrainingId = @TrainingId";

        private readonly IEntityListReader<User> _userListReader;

        public TrainingTraineesLoader(IEntityListReader<User> userListReader)
        {
            _userListReader = userListReader;
        }

        public IList<User> Load(ISession session, int trainingId)
        {
            using (var query = session.CreateQuery(SelectStatement))
            {
                query.Parameters.Add(new SqlParameter("@TrainingId", trainingId));
                return _userListReader.Read(session, query.ExecuteReader());
            }
        }
    }
}
