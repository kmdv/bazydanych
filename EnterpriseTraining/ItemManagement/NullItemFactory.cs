using System;
using System.Collections.Generic;

namespace EnterpriseTraining.ItemManagement
{
    public class NullItemFactory : IItemFactory
    {
        public IItem CreateNew()
        {
            throw new NotImplementedException();
        }

        public IList<IItem> CreateFullList()
        {
            return new List<IItem>();
        }
    }
}
