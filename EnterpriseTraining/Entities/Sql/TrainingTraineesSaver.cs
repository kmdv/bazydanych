using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class TrainingTraineesSaver : IEntitySaver<Training>
    {
        private const string DeleteOldStatement = "DELETE FROM Trainees WHERE TrainingId = @TrainingId";

        private const string InsertNewStatement = "INSERT INTO Trainees (UserId, TrainingId) VALUES (@UserId, @TrainingId)";

        private readonly IEntitySaver<Training> _decorated;

        public TrainingTraineesSaver(IEntitySaver<Training> decorated)
        {
            _decorated = decorated;
        }

        public void SaveNew(ISession session, Training training)
        {
            _decorated.SaveNew(session, training);

            UpdateTrainees(session, training);
        }

        public void SaveExisting(ISession session, Training training)
        {
            _decorated.SaveExisting(session, training);

            UpdateTrainees(session, training);
        }

        private void UpdateTrainees(ISession session, Training training)
        {
            using (var command = session.CreateCommand(DeleteOldStatement))
            {
                command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                command.ExecuteNonQuery();
            }

            foreach (var trainee in training.Trainees)
            {
                using (var command = session.CreateCommand(InsertNewStatement))
                {
                    command.Parameters.Add(new SqlParameter("@UserId", trainee.Id));
                    command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
