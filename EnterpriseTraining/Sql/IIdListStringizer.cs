using System.Collections.Generic;

using EnterpriseTraining.Entities;

namespace EnterpriseTraining.Sql
{
    public interface IIdListStringizer
    {
        string Stringize(IEnumerable<IEntity> entities);
    }
}
