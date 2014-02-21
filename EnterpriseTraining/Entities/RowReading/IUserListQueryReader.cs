using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface IUserListQueryReader
    {
        IList<User> Read(SqlCommand query);
    }
}
