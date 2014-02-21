using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class TrainingListReader : IEntityListReader<Training>
    {
        private readonly IEntityRowReader<Training> _rowReader;

        private readonly IEntityLoader<Certificate> _certificateLoader;

        private readonly ITrainingTraineesLoader _traineesLoader;

        private readonly ITrainingTrainersLoader _trainersLoader;

        public TrainingListReader(
            IEntityRowReader<Training> rowReader,
            IEntityLoader<Certificate> certificateLoader,
            ITrainingTraineesLoader traineesLoader,
            ITrainingTrainersLoader trainersLoader)
        {
            _rowReader = rowReader;
            _certificateLoader = certificateLoader;
            _traineesLoader = traineesLoader;
            _trainersLoader = trainersLoader;
        }

        public IList<Training> Read(ISession session, SqlDataReader reader)
        {
            var trainings = new List<Training>();
            while (reader.Read())
            {
                var training = _rowReader.Read(reader);

                if (!reader.IsDBNull(6))
                {
                    training.Certificate = _certificateLoader.TryToLoad(session, reader.GetInt32(6));
                }

                training.Trainees = _traineesLoader.Load(session, training.Id);
                training.Trainers = _trainersLoader.Load(session, training.Id);

                trainings.Add(training);
            }

            return trainings;
        }
    }
}
