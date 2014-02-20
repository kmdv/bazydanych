using System.Windows.Forms;

using EnterpriseTraining.ListManagement;

namespace EnterpriseTraining.UserManagement
{
    public class UserItemEditor : IListItemEditor
    {
        private readonly EditUserForm _editUserForm;

        private readonly IWin32Window _owner;

        public UserItemEditor(EditUserForm editUserForm, IWin32Window owner)
        {
            _editUserForm = editUserForm;
            _owner = owner;
        }

        public ListItemEditResult Edit(IListItem listItem)
        {
            var userItem = (UserItem)listItem;

            _editUserForm.User = userItem.User;
            _editUserForm.StartPosition = FormStartPosition.CenterParent;

            if (_editUserForm.ShowDialog(_owner) == DialogResult.OK)
            {
                userItem.User = _editUserForm.User;
                return ListItemEditResult.Success;
            }

            return ListItemEditResult.Cancelled;
        }
    }
}
