using System.Collections.Generic;
using System.Windows.Forms;

namespace EnterpriseTraining.ItemManagement
{
    public partial class ItemSelectForm : Form
    {
        public ItemSelectForm()
        {
            InitializeComponent();
        }

        public IList<IItem> Items
        {
            get
            {
                return itemDropDownList.Items;
            }

            set
            {
                itemDropDownList.Items = value;
            }
        }

        public IItem SelectedItem
        {
            get
            {
                return itemDropDownList.SelectedItem;
            }

            set
            {
                itemDropDownList.SelectedItem = value;
            }
        }

        private void ItemSelectForm_Shown(object sender, System.EventArgs e)
        {
            ActiveControl = itemDropDownList;
        }
    }
}
