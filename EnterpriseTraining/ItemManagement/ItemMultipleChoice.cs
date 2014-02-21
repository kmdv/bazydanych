using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriseTraining.ItemManagement
{
    public partial class ItemMultipleChoice : UserControl
    {
        private readonly BindingList<IItem> _bindingList = new BindingList<IItem>();

        private readonly List<IItem> _items = new List<IItem>();

        public ItemMultipleChoice()
        {
            InitializeComponent();

            checkedListBox.DataSource = _bindingList;
        }

        public IList<IItem> Items
        {
            get
            {
                return _bindingList;
            }

            set
            {
                _bindingList.Clear();

                if (value != null)
                {
                    foreach (var item in value)
                    {
                        _bindingList.Add(item);
                    }
                }
            }
        }

        public IList<int> CheckedIndices
        {
            get
            {
                var indices = new List<int>();
                foreach (int index in checkedListBox.CheckedIndices)
                {
                    indices.Add(index);
                }

                return indices;
            }

            set
            {
                for (int i = 0; i < checkedListBox.Items.Count; ++i)
                {
                    checkedListBox.SetItemChecked(i, false);
                }

                if (value != null)
                {
                    foreach (int index in value)
                    {
                        checkedListBox.SetItemChecked(index, true);
                    }
                }
            }
        }
    }
}
