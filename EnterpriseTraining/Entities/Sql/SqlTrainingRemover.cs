using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public class SqlTrainingRemover : IEntityRemover<Training>
    {
        private const string DeleteFormat = "DELETE FROM Trainings WHERE TrainingId IN ({0})";

        private const string DeleteTraineesFormat = "DELETE FROM Trainees WHERE TrainingId IN ({0})";

        private const string DeleteTrainersFormat = "DELETE FROM Trainers WHERE TrainingId IN ({0})";

        private readonly IIdListStringizer _idListStringizer;

        public SqlTrainingRemover(IIdListStringizer idListStringizer)
        {
            _idListStringizer = idListStringizer;
        }

        public void Remove(ISession session, IEnumerable<Training> trainings)
        {
            using (var command = session.CreateCommand())
            {
                command.CommandText = GetDeleteStatement(trainings);
                command.ExecuteNonQuery();
                command.CommandText = GetDeleteTraineesStatement(trainings);
                command.ExecuteNonQuery();
                command.CommandText = GetDeleteTrainersStatement(trainings);
                command.ExecuteNonQuery();
            }
        }

        private string GetDeleteStatement(IEnumerable<Training> trainings)
        {
            return string.Format(DeleteFormat, _idListStringizer.Stringize(trainings));
        }

        private string GetDeleteTraineesStatement(IEnumerable<Training> trainings)
        {
            return string.Format(DeleteTraineesFormat, _idListStringizer.Stringize(trainings));
        }

        private string GetDeleteTrainersStatement(IEnumerable<Training> trainings)
        {
            return string.Format(DeleteTrainersFormat, _idListStringizer.Stringize(trainings));
        }
    }
}
