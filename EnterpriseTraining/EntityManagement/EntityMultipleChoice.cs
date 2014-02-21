using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.ItemManagement;

namespace EnterpriseTraining.EntityManagement
{
    public partial class EntityMultipleChoice : UserControl
    {
        public EntityMultipleChoice()
        {
            InitializeComponent();
        }

        public void SetCheckedEntities<T>(IList<IItem> items, IList<T> checkedEntities)
            where T : class, IEntity
        {
            var checkedIndices = new List<int>();

            for (int i = 0; i < items.Count; ++i)
            {
                var entityItem = items[i] as EntityItem<T>;
                if (entityItem != null)
                {
                    var matches =
                        from entity
                        in checkedEntities
                        where entity.Id == entityItem.Entity.Id
                        select entity;

                    if (matches.Count() > 0)
                    {
                        checkedIndices.Add(i);
                    }
                }
            }

            itemMultipleChoice.Items = items;
            itemMultipleChoice.CheckedIndices = checkedIndices;
        }

        public IList<T> GetCheckedEntities<T>()
            where T : class, IEntity
        {
            var checkedEntities = new List<T>();

            var items = itemMultipleChoice.Items;
            var checkedIndices = itemMultipleChoice.CheckedIndices;

            for (int i = 0; i < items.Count; ++i)
            {
                if (checkedIndices.Contains(i))
                {
                    var entityItem = items[i] as EntityItem<T>;
                    if (entityItem != null)
                    {
                        checkedEntities.Add(entityItem.Entity);
                    }
                }
            }

            return checkedEntities;
        }
    }
}
