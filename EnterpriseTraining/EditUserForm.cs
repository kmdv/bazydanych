using System;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;
using EnterpriseTraining.FieldEditing;
using EnterpriseTraining.ItemManagement;

namespace EnterpriseTraining
{
    public partial class EditUserForm : Form, IEntityEditForm<User>
    {
        private const string IntFormat = "{0:d}";

        private readonly IFieldStringizer _fieldStringizer;

        private readonly IFieldParser _fieldParser;

        private readonly IItemFactory _certificateItemFactory;

        private User _user = new User();

        public User Entity
        {
            get { return _user; }
            set { _user = value; }
        }

        public EditUserForm(
            IFieldStringizer fieldStringizer,
            IFieldParser fieldParser,
            IItemFactory certificateItemFactory)
        {
            _fieldStringizer = fieldStringizer;
            _fieldParser = fieldParser;
            _certificateItemFactory = certificateItemFactory;

            InitializeComponent();
        }

        private void EditUser_Shown(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            firstNameTextBox.Text = _fieldStringizer.GetOptionalString(_user.FirstName);
            lastNameTextBox.Text = _fieldStringizer.GetOptionalString(_user.LastName);
            birthDatePicker.Value = GetConstrained(_user.BirthDate);
            emailAddressTextBox.Text = _fieldStringizer.GetOptionalString(_user.EmailAddress);
            countryTextBox.Text = _fieldStringizer.GetOptionalString(_user.Country);
            cityTextBox.Text = _fieldStringizer.GetOptionalString(_user.City);
            streetTextBox.Text = _fieldStringizer.GetOptionalString(_user.Street);
            houseNumberTextBox.Text = _fieldStringizer.GetOptionalInt(_user.HouseNumber);
            flatNumberTextBox.Text = _fieldStringizer.GetOptionalInt(_user.FlatNumber);
            postCodeTextBox.Text = _fieldStringizer.GetOptionalString(_user.PostCode);

            var certificateItems = _certificateItemFactory.CreateFullList();
            certificatesMultipleChoice.SetCheckedEntities(certificateItems, _user.Certificates);
        }

        private DateTime GetConstrained(DateTime dateTime)
        {
            if (dateTime == new DateTime())
            {
                return DateTime.Now;
            }

            if (dateTime < birthDatePicker.MinDate)
            {
                return birthDatePicker.MinDate;
            }

            if (dateTime > birthDatePicker.MaxDate)
            {
                return birthDatePicker.MaxDate;
            }

            return dateTime;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _user.FirstName = _fieldParser.ParseOptionalString(firstNameTextBox.Text);
            _user.LastName = _fieldParser.ParseOptionalString(lastNameTextBox.Text);
            _user.BirthDate = birthDatePicker.Value;
            _user.EmailAddress = _fieldParser.ParseOptionalString(emailAddressTextBox.Text);
            _user.Country = _fieldParser.ParseOptionalString(countryTextBox.Text);
            _user.City = _fieldParser.ParseOptionalString(cityTextBox.Text);
            _user.Street = _fieldParser.ParseOptionalString(streetTextBox.Text);
            _user.HouseNumber = _fieldParser.ParseOptionalInt(houseNumberTextBox.Text);
            _user.FlatNumber = _fieldParser.ParseOptionalInt(flatNumberTextBox.Text);
            _user.PostCode = _fieldParser.ParseOptionalString(postCodeTextBox.Text);
            _user.Certificates = certificatesMultipleChoice.GetCheckedEntities<Certificate>();
        }
    }
}
