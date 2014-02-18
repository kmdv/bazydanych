using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseTraining.Entities
{
    public interface IEntityManager : IEntityLoader, IEntityRemover, IEntitySaver
    {
    }
}
