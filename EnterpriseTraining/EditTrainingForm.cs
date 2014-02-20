using System;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;

namespace EnterpriseTraining
{
    public partial class EditTrainingForm : Form, IEntityEditForm<User>
    {
        private const string IntFormat = "{0:d}";

        private User _user = new User();

        public User Entity
        {
            get { return _user; }
            set { _user = value; }
        }

        public EditTrainingForm()
        {
            InitializeComponent();
        }

        private void EditUser_Shown(object sender, EventArgs e)
        {
            nameTextBox.Text = GetOptional(_user.FirstName);
            descriptionTextBox.Text = GetOptional(_user.LastName);
            startDatePicker.Value = GetConstrained(_user.BirthDate);
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

            if (dateTime < startDatePicker.MinDate)
            {
                return startDatePicker.MinDate;
            }

            if (dateTime > startDatePicker.MaxDate)
            {
                return startDatePicker.MaxDate;
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
            _user.FirstName = ToOptionalString(nameTextBox.Text);
            _user.LastName = ToOptionalString(descriptionTextBox.Text);
            _user.BirthDate = startDatePicker.Value;
            _user.Country = ToOptionalString(countryTextBox.Text);
            _user.City = ToOptionalString(cityTextBox.Text);
            _user.Street = ToOptionalString(streetTextBox.Text);
            _user.HouseNumber = ToOptionalInt(houseNumberTextBox.Text);
            _user.FlatNumber = ToOptionalInt(flatNumberTextBox.Text);
            _user.PostCode = ToOptionalString(postCodeTextBox.Text);
        }
    }
}
