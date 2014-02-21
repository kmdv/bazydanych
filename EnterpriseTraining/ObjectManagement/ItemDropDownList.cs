using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseTraining.ObjectManagement
{
    public partial class ItemDropDownList : UserControl
    {
        private BindingList<IItem> _bindingList = CreateEmptyBindingList();

        public ItemDropDownList()
        {
            InitializeComponent();

            comboBox.DataSource = _bindingList;
            comboBox.SelectedIndex = 0;
        }

        public IItem TryToGetSelectedItem()
        {
            if (comboBox.SelectedIndex > 0)
            {
                return _bindingList[comboBox.SelectedIndex];
            }

            return null;
        }

        public void SetItems(IList<IItem> items)
        {
            var newBindingList = CreateEmptyBindingList();
            foreach (var item in items)
            {
                newBindingList.Add(item);
            }

            comboBox.DataSource = newBindingList;
            _bindingList = newBindingList;
        }

        private static BindingList<IItem> CreateEmptyBindingList()
        {
            var bindingList = new BindingList<IItem>();
            bindingList.Add(new NoneItem());
            return bindingList;
        }
    }
}
