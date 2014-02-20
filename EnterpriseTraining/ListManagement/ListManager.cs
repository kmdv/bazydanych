using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriseTraining.ListManagement
{
    public partial class ListManager : UserControl
    {
        private readonly BindingList<IListItem> _bindingList = new BindingList<IListItem>();

        public IListItemFactory ItemFactory { get; set; }
        public IListItemEditor ItemEditor { get; set; }
        public IListItemSaver ItemSaver { get; set; }
        public IListItemRemover ItemRemover { get; set; }

        public ListManager()
        {
            ItemFactory = new NullListItemFactory();
            ItemEditor = new NullListItemEditor();
            ItemSaver = new NullListItemSaver();
            ItemRemover = new NullListItemRemover();

            InitializeComponent();

            listBox.DataSource = _bindingList;
        }

        private void ListManager_Load(object sender, EventArgs e)
        {
            foreach (var item in ItemFactory.CreateFullList())
            {
                _bindingList.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newItem = ItemFactory.CreateNew();

            if (ItemEditor.Edit(newItem) == ListItemEditResult.Success)
            {
                ItemSaver.SaveNew(newItem);
                _bindingList.Add(newItem);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    "Are you sure you want to remove the selected items?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selectedItems = GetSelectedItems();

                    ItemRemover.Remove(selectedItems);

                    RemoveItems(selectedItems);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                var item = _bindingList[listBox.SelectedIndex];
                
                if (ItemEditor.Edit(item) == ListItemEditResult.Success)
                {
                    ItemSaver.SaveExisting(item);
                }
            }
        }

        private IList<IListItem> GetSelectedItems()
        {
            var selectedItems = new List<IListItem>();
            foreach (var item in listBox.SelectedItems)
            {
                selectedItems.Add((IListItem)item);
            }

            return selectedItems;
        }

        private void RemoveItems(IEnumerable<IListItem> items)
        {
            foreach (var item in items)
            {
                _bindingList.Remove(item);
            }
        }
    }
}
