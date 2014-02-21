using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public interface IEntityRemover<T>
        where T : class, IEntity
    {
        void Remove(ISession session, IEnumerable<T> entities);
    }
}
