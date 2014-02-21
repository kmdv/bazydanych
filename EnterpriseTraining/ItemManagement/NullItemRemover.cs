using System.Collections.Generic;

namespace EnterpriseTraining.ItemManagement
{
    public class NullItemRemover : IItemRemover
    {
        public void Remove(IEnumerable<IItem> items)
        {
        }
    }
}
