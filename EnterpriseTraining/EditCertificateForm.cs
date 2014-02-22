using System;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;
using EnterpriseTraining.FieldEditing;

namespace EnterpriseTraining
{
    public partial class EditCertificateForm : Form, IEntityEditForm<Certificate>
    {
        private const string IntFormat = "{0:d}";

        private readonly IFieldStringizer _fieldStringizer;

        private readonly IFieldParser _fieldParser;

        private Certificate _certificate = new Certificate();

        public Certificate Entity
        {
            get { return _certificate; }
            set { _certificate = value; }
        }

        public EditCertificateForm(IFieldStringizer fieldStringizer, IFieldParser fieldParser)
        {
            _fieldStringizer = fieldStringizer;
            _fieldParser = fieldParser;

            InitializeComponent();
        }

        private void EditUser_Shown(object sender, EventArgs e)
        {
            nameTextBox.Text = _fieldStringizer.GetMandatoryString(_certificate.Name);
            validityYearsTextBox.Text = _fieldStringizer.GetMandatoryInt(_certificate.ValidityYears);

            ActiveControl = nameTextBox;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _certificate.Name = _fieldParser.ParseMandatoryString(nameTextBox.Text);
            _certificate.ValidityYears = _fieldParser.ParseMandatoryInt(validityYearsTextBox.Text);
        }
    }
}
