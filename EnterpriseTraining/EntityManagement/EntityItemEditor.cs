using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.ItemManagement;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemEditor<T, TForm> : IItemEditor
        where T : class, IEntity
        where TForm : Form, IEntityEditForm<T>
    {
        private readonly TForm _editForm;

        private readonly IWin32Window _owner;

        public EntityItemEditor(TForm editForm, IWin32Window owner)
        {
            _editForm = editForm;
            _owner = owner;
        }

        public ItemEditResult Edit(IItem item)
        {
            var entityItem = (EntityItem<T>)item;

            _editForm.Entity = entityItem.Entity;

            if (_editForm.ShowDialog(_owner) == DialogResult.OK)
            {
                entityItem.Entity = _editForm.Entity;
                return ItemEditResult.Success;
            }

            return ItemEditResult.Cancelled;
        }
    }
}
