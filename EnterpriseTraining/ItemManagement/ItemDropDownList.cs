using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseTraining.ItemManagement
{
    public partial class ItemDropDownList : UserControl
    {
        private BindingList<IItem> _bindingList = CreateEmptyBindingList();

        private IList<IItem> _items = new List<IItem>();

        public ItemDropDownList()
        {
            InitializeComponent();

            comboBox.DataSource = _bindingList;
            comboBox.SelectedIndex = 0;
        }

        public IItem SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex > 0 ? _bindingList[comboBox.SelectedIndex] : null;
            }

            set
            {
                comboBox.SelectedIndex = _bindingList.Contains(value) ? _bindingList.IndexOf(value) : 0;
            }
        }

        public IList<IItem> Items
        {
            get
            {
                return _items;
            }

            set
            {
                var newBindingList = CreateEmptyBindingList();
                foreach (var item in value)
                {
                    newBindingList.Add(item);
                }

                comboBox.DataSource = newBindingList;
                _bindingList = newBindingList;
                _items = value;
            }
        }

        private static BindingList<IItem> CreateEmptyBindingList()
        {
            var bindingList = new BindingList<IItem>();
            bindingList.Add(new NoneItem());
            return bindingList;
        }
    }
}
