using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public interface IEntityLoader<T>
        where T : class, IEntity
    {
        T TryToLoad(ISession session, int id);

        IList<T> TryToLoad(ISession session, IEnumerable<int> ids);

        IList<T> LoadAll(ISession session);
    }
}
