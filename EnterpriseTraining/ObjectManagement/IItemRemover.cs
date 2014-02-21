using System.Collections.Generic;

namespace EnterpriseTraining.ObjectManagement
{
    public interface IItemRemover
    {
        void Remove(IEnumerable<IItem> items);
    }
}
