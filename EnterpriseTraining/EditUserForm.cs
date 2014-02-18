using System;
using System.Windows.Forms;
using System.Globalization;

using EnterpriseTraining.Entities;

namespace EnterpriseTraining
{
    public partial class EditUserForm : Form
    {
        private const string IntFormat = "{0:d}";

        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public EditUserForm()
        {
            User = new User();

            InitializeComponent();
        }

        private void EditUser_Shown(object sender, EventArgs e)
        {
            firstNameTextBox.Text = GetOptional(_user.FirstName);
            lastNameTextBox.Text = GetOptional(_user.LastName);
            birthDatePicker.Value = GetConstrained(_user.BirthDate);
            emailAddressTextBox.Text = GetOptional(_user.EmailAddress);
            countryTextBox.Text = GetOptional(_user.Country);
            cityTextBox.Text = GetOptional(_user.City);
            streetTextBox.Text = GetOptional(_user.Street);
            houseNumberTextBox.Text = GetOptional(_user.HouseNumber);
            flatNumberTextBox.Text = GetOptional(_user.FlatNumber);
            postCodeTextBox.Text = GetOptional(_user.PostCode);
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

        private string GetOptional(string value)
        {
            return value == null ? string.Empty : value;
        }

        private string GetOptional(int? value)
        {
            return value == null ? string.Empty : string.Format(IntFormat, value);
        }

        private string ToOptionalString(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }

        private int? ToOptionalInt(string value)
        {
            return string.IsNullOrEmpty(value)
                ? null as int?
                : int.Parse(value);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _user.FirstName = ToOptionalString(firstNameTextBox.Text);
            _user.LastName = ToOptionalString(lastNameTextBox.Text);
            _user.BirthDate = birthDatePicker.Value;
            _user.EmailAddress = ToOptionalString(emailAddressTextBox.Text);
            _user.Country = ToOptionalString(countryTextBox.Text);
            _user.City = ToOptionalString(cityTextBox.Text);
            _user.Street = ToOptionalString(streetTextBox.Text);
            _user.HouseNumber = ToOptionalInt(houseNumberTextBox.Text);
            _user.FlatNumber = ToOptionalInt(flatNumberTextBox.Text);
            _user.PostCode = ToOptionalString(postCodeTextBox.Text);
        }
    }
}
