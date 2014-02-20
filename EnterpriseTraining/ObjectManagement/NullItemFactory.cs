using System;
using System.Collections.Generic;

namespace EnterpriseTraining.ObjectManagement
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
