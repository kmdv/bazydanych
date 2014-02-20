using System.Collections.Generic;

namespace EnterpriseTraining.ListManagement
{
    public interface IListItemFactory
    {
        IListItem CreateNew();

        IList<IListItem> CreateFullList();
    }
}
