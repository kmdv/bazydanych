using System.Collections.Generic;
using System.Linq;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities.RowReading;

namespace EnterpriseTraining.Entities
{
    public sealed class EntityLoader<T> : IEntityLoader<T>
        where T : class, IEntity
    {
        private readonly IIdListStringizer _idListStringizer;

        private readonly IEntityListReader<T> _listReader;

        public string SelectByIdFormat { get; set; }

        public string SelectAllStatement { get; set; }

        public EntityLoader(IIdListStringizer idListStringizer, IEntityListReader<T> listReader)
        {
            _idListStringizer = idListStringizer;
            _listReader = listReader;
        }

        public T TryToLoad(ISession session, int id)
        {
            return TryToLoad(session, new List<int> { id }).FirstOrDefault();
        }

        public IList<T> TryToLoad(ISession session, IEnumerable<int> ids)
        {
            string queryText = string.Format(SelectByIdFormat, _idListStringizer.Stringize(ids));

            using (var query = session.CreateQuery(queryText))
            {
                using (var reader = query.ExecuteReader())
                {
                    return _listReader.Read(session, reader);
                }
            }
        }

        public IList<T> LoadAll(ISession session)
        {
            using (var query = session.CreateQuery(SelectAllStatement))
            {
                using (var reader = query.ExecuteReader())
                {
                    return _listReader.Read(session, reader);
                }
            }
        }

        public static EntityLoader<T> CreateForTable(
            IIdListStringizer idListStringizer,
            IEntityListReader<T> listReader,
            string tableName,
            string idColumnName,
            string otherColumnNames)
        {
            return new EntityLoader<T>(idListStringizer, listReader)
            {
                SelectByIdFormat = string.Format("SELECT {0}, {1} FROM {2} T WHERE T.{0} IN ({{0}})", idColumnName, otherColumnNames, tableName),
                SelectAllStatement = string.Format("SELECT {0}, {1} FROM {2}", idColumnName, otherColumnNames, tableName)
            };
        }
    }
}
