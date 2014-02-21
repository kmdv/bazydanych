using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriseTraining.ObjectManagement
{
    public partial class ItemListManager : UserControl
    {
        private readonly BindingList<IItem> _bindingList = new BindingList<IItem>();

        public IItemFactory ItemFactory { get; set; }
        public IItemEditor ItemEditor { get; set; }
        public IItemSaver ItemSaver { get; set; }
        public IItemRemover ItemRemover { get; set; }

        public ItemListManager()
        {
            ItemFactory = new NullItemFactory();
            ItemEditor = new NullItemEditor();
            ItemSaver = new NullItemSaver();
            ItemRemover = new NullItemRemover();

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

            if (ItemEditor.Edit(newItem) == ItemEditResult.Success)
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
                
                if (ItemEditor.Edit(item) == ItemEditResult.Success)
                {
                    ItemSaver.SaveExisting(item);
                }
            }
        }

        private IList<IItem> GetSelectedItems()
        {
            var selectedItems = new List<IItem>();
            foreach (var item in listBox.SelectedItems)
            {
                selectedItems.Add((IItem)item);
            }

            return selectedItems;
        }

        private void RemoveItems(IEnumerable<IItem> items)
        {
            foreach (var item in items)
            {
                _bindingList.Remove(item);
            }
        }
    }
}
