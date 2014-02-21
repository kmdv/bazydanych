using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.RowReading
{
    public sealed class UserListQueryReader : IUserListQueryReader
    {
        private readonly IUserRowReader _rowReader;

        public UserListQueryReader(IUserRowReader rowReader)
        {
            _rowReader = rowReader;
        }

        public IList<User> Read(SqlCommand query)
        {
            using (var reader = query.ExecuteReader())
            {
                var list = new List<User>();
                while (reader.Read())
                {
                    list.Add(_rowReader.Read(reader));
                }

                return list;
            }
        }
    }
}
