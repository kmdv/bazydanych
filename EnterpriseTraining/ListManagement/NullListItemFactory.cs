using System;
using System.Collections.Generic;

namespace EnterpriseTraining.ListManagement
{
    public class NullListItemFactory : IListItemFactory
    {
        public IListItem CreateNew()
        {
            throw new NotImplementedException();
        }

        public IList<IListItem> CreateFullList()
        {
            return new List<IListItem>();
        }
    }
}
