using System.Collections.Generic;

namespace EnterpriseTraining.ListManagement
{
    public interface IListItemRemover
    {
        void Remove(IEnumerable<IListItem> listItems);
    }
}
