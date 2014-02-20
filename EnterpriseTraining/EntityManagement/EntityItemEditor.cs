﻿using System.Windows.Forms;

using EnterpriseTraining.ObjectManagement;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItemEditor<T, TForm> : IItemEditor
        where T : class
        where TForm : Form, IEntityEditForm<T>
    {
        private readonly TForm _editForm;

        private readonly IWin32Window _owner;

        public EntityItemEditor(TForm editForm, IWin32Window owner)
        {
            _editForm = editForm;
            _owner = owner;
        }

        public ItemEditResult Edit(IItem listItem)
        {
            var userItem = (EntityItem<T>)listItem;

            _editForm.Entity = userItem.Entity;
            _editForm.StartPosition = FormStartPosition.CenterParent;

            if (_editForm.ShowDialog(_owner) == DialogResult.OK)
            {
                userItem.Entity = _editForm.Entity;
                return ItemEditResult.Success;
            }

            return ItemEditResult.Cancelled;
        }
    }
}
