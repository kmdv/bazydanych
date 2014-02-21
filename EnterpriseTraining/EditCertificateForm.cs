using System;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;

namespace EnterpriseTraining
{
    public partial class EditCertificateForm : Form, IEntityEditForm<Certificate>
    {
        private const string IntFormat = "{0:d}";

        private Certificate _certificate = new Certificate();

        public Certificate Entity
        {
            get { return _certificate; }
            set { _certificate = value; }
        }

        public EditCertificateForm()
        {
            InitializeComponent();
        }

        private void EditUser_Shown(object sender, EventArgs e)
        {
            nameTextBox.Text = _certificate.Name;
            ActiveControl = nameTextBox;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _certificate.Name = nameTextBox.Text;
        }
    }
}
