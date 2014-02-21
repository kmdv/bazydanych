using System.Collections.Generic;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public interface IEntityLoader<T>
        where T : class, IEntity
    {
        IList<T> LoadAll(ISession session);
    }
}
