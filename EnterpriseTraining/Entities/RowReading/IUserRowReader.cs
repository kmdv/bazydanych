using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface IUserRowReader
    {
        User Read(SqlDataReader reader);
    }
}
