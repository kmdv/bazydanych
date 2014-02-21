using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class TrainingTraineesRemover : IEntityRemover<Training>
    {
        private const string DeleteFormat = "DELETE FROM Trainees WHERE TrainingId IN ({0})";

        private readonly IIdListStringizer _idListStringizer;

        private readonly IEntityRemover<Training> _decorated;

        public TrainingTraineesRemover(IIdListStringizer idListStringizer, IEntityRemover<Training> decorated)
        {
            _idListStringizer = idListStringizer;
            _decorated = decorated;
        }

        public void Remove(ISession session, IEnumerable<Training> trainings)
        {
            using (var command = session.CreateCommand(GetDeleteStatement(trainings)))
            {
                command.ExecuteNonQuery();
            }

            _decorated.Remove(session, trainings);
        }

        private string GetDeleteStatement(IEnumerable<Training> trainings)
        {
            return string.Format(DeleteFormat, _idListStringizer.Stringize(trainings));
        }
    }
}
