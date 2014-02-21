using System;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;

namespace EnterpriseTraining
{
    public partial class EditTrainingForm : Form, IEntityEditForm<Training>
    {
        private const string IntFormat = "{0:d}";

        private Training _training = new Training();

        public Training Entity
        {
            get { return _training; }
            set { _training = value; }
        }

        public EditTrainingForm()
        {
            InitializeComponent();
        }

        private void EditUser_Shown(object sender, EventArgs e)
        {
            nameTextBox.Text = _training.Name;
            descriptionTextBox.Text = _training.Description;
            startDatePicker.Value = GetConstrained(_training.StartDate, startDatePicker);
            endDatePicker.Value = GetConstrained(_training.EndDate, endDatePicker);
            costTextBox.Text = string.Format(IntFormat, _training.Cost);
            requiredPointsTextBox.Text = string.Format(IntFormat, _training.RequiredPoints);
            maxPointsTextBox.Text = string.Format(IntFormat, _training.MaxPoints);
        }

        private DateTime GetConstrained(DateTime dateTime, DateTimePicker picker)
        {
            if (dateTime == new DateTime())
            {
                return DateTime.Now;
            }

            if (dateTime < picker.MinDate)
            {
                return picker.MinDate;
            }

            if (dateTime > picker.MaxDate)
            {
                return picker.MaxDate;
            }

            return dateTime;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _training.Name = nameTextBox.Text;
            _training.Description = descriptionTextBox.Text;
            _training.StartDate = startDatePicker.Value;
            _training.EndDate = endDatePicker.Value;
            _training.Cost = decimal.Parse(costTextBox.Text);
            _training.RequiredPoints = int.Parse(costTextBox.Text);
            _training.MaxPoints = int.Parse(costTextBox.Text);
        }
    }
}
