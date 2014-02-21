using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;
using EnterpriseTraining.ItemManagement;
using EnterpriseTraining.FieldEditing;

namespace EnterpriseTraining
{
    public partial class EditTrainingForm : Form, IEntityEditForm<Training>
    {
        public delegate IList<Certificate> ReloadCertificates();

        private const string IntFormat = "{0:d}";

        private readonly IFieldStringizer _fieldStringizer;

        private readonly IFieldParser _fieldParser;

        private readonly ReloadCertificates _reloadCertificates;

        private Training _training = new Training();

        public Training Entity
        {
            get { return _training; }
            set { _training = value; }
        }

        public EditTrainingForm(IFieldStringizer fieldStringizer, IFieldParser fieldParser, ReloadCertificates reloadCertificates)
        {
            _fieldStringizer = fieldStringizer;
            _fieldParser = fieldParser;
            _reloadCertificates = reloadCertificates;

            InitializeComponent();
        }

        private void EditTrainingForm_Shown(object sender, EventArgs e)
        {
            SetCertificates(_reloadCertificates());

            nameTextBox.Text = _fieldStringizer.GetMandatoryString(_training.Name);
            descriptionTextBox.Text = _fieldStringizer.GetMandatoryString(_training.Description);

            startDatePicker.Value = GetConstrained(_training.StartDate, startDatePicker);
            endDatePicker.Value = GetConstrained(_training.EndDate, endDatePicker);

            costTextBox.Text = _fieldStringizer.GetMandatoryDecimal(_training.Cost);

            requiredPointsTextBox.Text = _fieldStringizer.GetMandatoryInt(_training.RequiredPoints);
            maxPointsTextBox.Text = _fieldStringizer.GetMandatoryInt(_training.MaxPoints);
        }

        private void SetCertificates(IList<Certificate> certificates)
        {
            var stringizer = new CertificateStringizer();
            IItem toBeSelected = null;

            var items = new List<IItem>();
            foreach (var certificate in certificates)
            {
                var item = new EntityItem<Certificate>(stringizer) { Entity = certificate };

                items.Add(item);

                if (_training.Certificate != null && certificate.Id == _training.Certificate.Id)
                {
                    toBeSelected = item;
                }
            }

            certificateDropDownList.Items = items;
            certificateDropDownList.SelectedItem = toBeSelected;
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
            _training.Name = _fieldParser.ParseMandatoryString(nameTextBox.Text);
            _training.Description = _fieldParser.ParseMandatoryString(descriptionTextBox.Text);

            _training.StartDate = startDatePicker.Value;
            _training.EndDate = endDatePicker.Value;

            var certificateItem = certificateDropDownList.SelectedItem as EntityItem<Certificate>;
            _training.Certificate = certificateItem == null ? null : certificateItem.Entity;

            _training.Cost = _fieldParser.ParseMandatoryDecimal(costTextBox.Text);

            _training.RequiredPoints = _fieldParser.ParseMandatoryInt(requiredPointsTextBox.Text);
            _training.MaxPoints = _fieldParser.ParseMandatoryInt(maxPointsTextBox.Text);
        }
    }
}
