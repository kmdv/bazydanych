using System.Collections.Generic;

using EnterpriseTraining.Entities;

namespace EnterpriseTraining.Sql
{
    public class IdListStringizer : IIdListStringizer
    {
        private const string IdFormat = "{0:d}";
        private const string IdSeparator = ", ";

        public string Stringize(IEnumerable<IEntity> entities)
        {
            return GetIdsAsString(GetIds(entities));
        }

        private IList<int> GetIds(IEnumerable<IEntity> entities)
        {
            var ids = new List<int>();
            foreach (var entity in entities)
            {
                ids.Add(entity.Id);
            }

            return ids;
        }

        private string GetIdsAsString(IEnumerable<int> ids)
        {
            return string.Join(IdSeparator, GetIdsAsStringList(ids));
        }

        private IList<string> GetIdsAsStringList(IEnumerable<int> ids)
        {
            var idsAsStringList = new List<string>();
            foreach (int id in ids)
            {
                idsAsStringList.Add(string.Format(IdFormat, id));
            }

            return idsAsStringList;
        }
    }
}
