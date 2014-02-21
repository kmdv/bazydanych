using System.Collections.Generic;

namespace EnterpriseTraining.ObjectManagement
{
    public class NullItemRemover : IItemRemover
    {
        public void Remove(IEnumerable<IItem> items)
        {
        }
    }
}
