using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class TrainingTrainersSaver : IEntitySaver<Training>
    {
        private const string DeleteOldStatement = "DELETE FROM Trainers WHERE TrainingId = @TrainingId";

        private const string InsertNewStatement = "INSERT INTO Trainers (UserId, TrainingId) VALUES (@UserId, @TrainingId)";

        private readonly IEntitySaver<Training> _decorated;

        public TrainingTrainersSaver(IEntitySaver<Training> decorated)
        {
            _decorated = decorated;
        }

        public void SaveNew(ISession session, Training training)
        {
            _decorated.SaveNew(session, training);

            UpdateTrainers(session, training);
        }

        public void SaveExisting(ISession session, Training training)
        {
            _decorated.SaveExisting(session, training);

            UpdateTrainers(session, training);
        }

        private void UpdateTrainers(ISession session, Training training)
        {
            using (var command = session.CreateCommand(DeleteOldStatement))
            {
                command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                command.ExecuteNonQuery();
            }

            foreach (var trainer in training.Trainers)
            {
                using (var command = session.CreateCommand(InsertNewStatement))
                {
                    command.Parameters.Add(new SqlParameter("@UserId", trainer.Id));
                    command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
