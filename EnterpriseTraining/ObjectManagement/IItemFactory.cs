using System.Collections.Generic;

namespace EnterpriseTraining.ObjectManagement
{
    public interface IItemFactory
    {
        IItem CreateNew();

        IList<IItem> CreateFullList();
    }
}
