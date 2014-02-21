using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class TrainingListQueryReader : ITrainingListQueryReader
    {
        private readonly ITrainingRowReader _rowReader;

        public TrainingListQueryReader(ITrainingRowReader rowReader)
        {
            _rowReader = rowReader;
        }

        public IList<Training> Read(SqlCommand query)
        {
            using (var reader = query.ExecuteReader())
            {
                var trainings = new List<Training>();
                while (reader.Read())
                {
                    trainings.Add(_rowReader.Read(reader));
                }

                return trainings;
            }
        }
    }
}
