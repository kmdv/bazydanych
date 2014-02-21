using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public interface IOptionalCellReader
    {
        string ReadString(SqlDataReader reader, int index);

        int? ReadInt(SqlDataReader reader, int index);
    }
}
