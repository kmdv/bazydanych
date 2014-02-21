using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class TrainingSaver : AbstractEntitySaver<Training>
    {
        private const string CustomInsertStatement =
            "INSERT INTO Trainings (Name, Description, StartDate, EndDate, Cost, CertificateId, RequiredPoints, MaxPoints) " +
            "VALUES (@Name, @Description, @StartDate, @EndDate, @Cost, @CertificateId, @RequiredPoints, @MaxPoints)" +
            "SET @Id = SCOPE_IDENTITY()";

        private const string CustomUpdateStatement =
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

        private const string CustomIdColumnName = "TrainingId";

        private const string CustomIdParameterName = "@Id";

        protected override void AddCommonFields(SqlCommand command, Training training)
        {
            command.Parameters.Add(new SqlParameter("@Name", training.Name));
            command.Parameters.Add(new SqlParameter("@Description", training.Description));
            command.Parameters.Add(new SqlParameter("@StartDate", training.StartDate));
            command.Parameters.Add(new SqlParameter("@EndDate", training.EndDate));
            command.Parameters.Add(new SqlParameter("@Cost", training.Cost));
            command.Parameters.Add(new SqlParameter("@CertificateId", GetCertificateId(training)));
            command.Parameters.Add(new SqlParameter("@RequiredPoints", training.RequiredPoints));
            command.Parameters.Add(new SqlParameter("@MaxPoints", training.MaxPoints));
        }

        private static int? GetCertificateId(Training training)
        {
            return training.Certificate == null ? null as int? : training.Certificate.Id;
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
