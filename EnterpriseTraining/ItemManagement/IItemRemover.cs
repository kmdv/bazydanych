using System.Collections.Generic;

namespace EnterpriseTraining.ItemManagement
{
    public interface IItemRemover
    {
        void Remove(IEnumerable<IItem> items);
    }
}
