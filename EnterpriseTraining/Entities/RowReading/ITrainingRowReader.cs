using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface ITrainingRowReader
    {
        Training Read(SqlDataReader reader);
    }
}
