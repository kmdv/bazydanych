using System.Windows.Forms;

using EnterpriseTraining.ListManagement;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemEditor<T, TForm> : IListItemEditor
        where TForm : Form, IEntityEditForm<T>
    {
        private readonly TForm _editForm;

        private readonly IWin32Window _owner;

        public EntityItemEditor(TForm editForm, IWin32Window owner)
        {
            _editForm = editForm;
            _owner = owner;
        }

        public ListItemEditResult Edit(IListItem listItem)
        {
            var userItem = (EntityItem<T>)listItem;

            _editForm.Entity = userItem.Entity;
            _editForm.StartPosition = FormStartPosition.CenterParent;

            if (_editForm.ShowDialog(_owner) == DialogResult.OK)
            {
                userItem.Entity = _editForm.Entity;
                return ListItemEditResult.Success;
            }

            return ListItemEditResult.Cancelled;
        }
    }
}
