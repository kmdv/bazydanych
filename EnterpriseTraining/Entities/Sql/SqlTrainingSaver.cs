using System;
using System.Data;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public sealed class SqlTrainingSaver : IEntitySaver<Training>
    {
        private const string InsertStatement =
            "INSERT INTO Trainings (Name, Description, StartDate, EndDate, Cost, CertificateId, RequiredPoints, MaxPoints) " +
            "VALUES (@Name, @Description, @StartDate, @EndDate, @Cost, @CertificateId, @RequiredPoints, @MaxPoints)" +
            "SET @Id = SCOPE_IDENTITY()";

        private const string UpdateStatement =
            "UPDATE Trainings SET " +
            "Name=@Name, " +
            "Description=@Description, " +
            "StartDate=@StartDate, " +
            "EndDate=@EndDate, " +
            "Cost=@Cost, " +
            "CertificateId=@CertificateId, " +
            "RequiredPoints=@RequiredPoints, " +
            "MaxPoints=@MaxPoints " +
            "WHERE TrainingId=@Id";

        private const string DeleteOldTrainersStatement = "DELETE FROM Trainers WHERE TrainingId = @TrainingId";
        private const string DeleteOldTraineesStatement = "DELETE FROM Trainees WHERE TrainingId = @TrainingId";

        private const string InsertNewTrainersStatement = "INSERT INTO Trainers (UserId, TrainingId) VALUES (@UserId, @TrainingId)";
        private const string InsertNewTraineesStatement = "INSERT INTO Trainees (UserId, TrainingId) VALUES (@UserId, @TrainingId)";

        public void SaveNew(ISession session, Training training)
        {
            using (var command = session.CreateCommand(InsertStatement))
            {
                AddCommonFields(command, training);

                command.Parameters.Add("@Id", SqlDbType.Int, 0, "TrainingId").Direction = ParameterDirection.Output;

                EnableNullValues(command);

                command.ExecuteNonQuery();

                SetNewId(command, training);
            }

            UpdateTrainers(session, training);
            UpdateTrainees(session, training);
        }

        public void SaveExisting(ISession session, Training training)
        {
            using (var command = session.CreateCommand(UpdateStatement))
            {
                AddCommonFields(command, training);

                command.Parameters.Add(new SqlParameter("@Id", training.Id));

                EnableNullValues(command);

                command.ExecuteNonQuery();
            }

            UpdateTrainers(session, training);
            UpdateTrainees(session, training);
        }

        private void AddCommonFields(SqlCommand command, Training training)
        {
            command.Parameters.Add(new SqlParameter("@Name", training.Name));
            command.Parameters.Add(new SqlParameter("@Description", training.Description));
            command.Parameters.Add(new SqlParameter("@StartDate", training.StartDate));
            command.Parameters.Add(new SqlParameter("@EndDate", training.EndDate));
            command.Parameters.Add(new SqlParameter("@Cost", training.Cost));
            command.Parameters.Add(new SqlParameter("@CertificateId", training.Certificate == null ? null as int? : training.Certificate.Id));
            command.Parameters.Add(new SqlParameter("@RequiredPoints", training.RequiredPoints));
            command.Parameters.Add(new SqlParameter("@MaxPoints", training.MaxPoints));
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

        private void SetNewId(SqlCommand command, Training training)
        {
            training.Id = (int)command.Parameters["@Id"].Value;
        }

        private void UpdateTrainers(ISession session, Training training)
        {
            using (var command = session.CreateCommand(DeleteOldTrainersStatement))
            {
                command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                command.ExecuteNonQuery();
            }

            foreach (var trainer in training.Trainers)
            {
                using (var command = session.CreateCommand(InsertNewTrainersStatement))
                {
                    command.Parameters.Add(new SqlParameter("@UserId", trainer.Id));
                    command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdateTrainees(ISession session, Training training)
        {
            using (var command = session.CreateCommand(DeleteOldTraineesStatement))
            {
                command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                command.ExecuteNonQuery();
            }

            foreach (var trainee in training.Trainees)
            {
                using (var command = session.CreateCommand(InsertNewTraineesStatement))
                {
                    command.Parameters.Add(new SqlParameter("@UserId", trainee.Id));
                    command.Parameters.Add(new SqlParameter("@TrainingId", training.Id));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
