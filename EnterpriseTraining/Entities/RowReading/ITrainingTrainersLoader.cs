using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface ITrainingTrainersLoader
    {
        IList<User> Load(ISession session, int trainingId);
    }
}
