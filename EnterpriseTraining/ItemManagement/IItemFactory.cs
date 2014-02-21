using System.Collections.Generic;

namespace EnterpriseTraining.ItemManagement
{
    public interface IItemFactory
    {
        IItem CreateNew();

        IList<IItem> CreateFullList();
    }
}
