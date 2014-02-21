using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public sealed class OptionalCellReader : IOptionalCellReader
    {
        public string ReadString(SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null : reader.GetString(index);
        }

        public int? ReadInt(SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? null as int? : reader.GetInt32(index);
        }
    }
}
