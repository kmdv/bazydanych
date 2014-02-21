using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;
using EnterpriseTraining.ItemManagement;
using EnterpriseTraining.FieldEditing;

namespace EnterpriseTraining
{
    public partial class EditTrainingForm : Form, IEntityEditForm<Training>
    {
        private const string IntFormat = "{0:d}";

        private readonly IFieldStringizer _fieldStringizer;

        private readonly IFieldParser _fieldParser;

        private readonly ItemSelectForm _itemSelectForm;

        private readonly IItemFactory _userItemFactory;

        private readonly IItemFactory _certificateItemFactory;

        private Training _training = new Training();

        private Certificate _newCertificate = null;

        public Training Entity
        {
            get { return _training; }
            set { _training = value; }
        }

        public EditTrainingForm(
            IFieldStringizer fieldStringizer,
            IFieldParser fieldParser,
            ItemSelectForm itemSelectForm,
            IItemFactory userItemFactory,
            IItemFactory certificateItemFactory)
        {
            _fieldStringizer = fieldStringizer;
            _fieldParser = fieldParser;
            _itemSelectForm = itemSelectForm;
            _userItemFactory = userItemFactory;
            _certificateItemFactory = certificateItemFactory;

            InitializeComponent();
        }

        private void EditTrainingForm_Shown(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            nameTextBox.Text = _fieldStringizer.GetMandatoryString(_training.Name);
            descriptionTextBox.Text = _fieldStringizer.GetMandatoryString(_training.Description);

            startDatePicker.Value = GetConstrained(_training.StartDate, startDatePicker);
            endDatePicker.Value = GetConstrained(_training.EndDate, endDatePicker);

            _newCertificate = _training.Certificate;

            costTextBox.Text = _fieldStringizer.GetMandatoryDecimal(_training.Cost);

            requiredPointsTextBox.Text = _fieldStringizer.GetMandatoryInt(_training.RequiredPoints);
            maxPointsTextBox.Text = _fieldStringizer.GetMandatoryInt(_training.MaxPoints);

            var userItems = _userItemFactory.CreateFullList();
            trainersMultipleChoice.SetCheckedEntities(userItems, _training.Trainers);
            traineesMultipleChoice.SetCheckedEntities(userItems, _training.Trainees);
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

            _training.Certificate = _newCertificate;
            _training.Cost = _fieldParser.ParseMandatoryDecimal(costTextBox.Text);

            _training.Trainers = trainersMultipleChoice.GetCheckedEntities<User>();
            _training.Trainees = traineesMultipleChoice.GetCheckedEntities<User>();

            _training.RequiredPoints = _fieldParser.ParseMandatoryInt(requiredPointsTextBox.Text);
            _training.MaxPoints = _fieldParser.ParseMandatoryInt(maxPointsTextBox.Text);
        }

        private void selectCertificateButton_Click(object sender, EventArgs e)
        {
            _itemSelectForm.Items = _certificateItemFactory.CreateFullList();

            if (_newCertificate != null)
            {
                _itemSelectForm.SelectedItem = _itemSelectForm.Items.FirstOrDefault(
                    item => item is EntityItem<Certificate>
                        ? (item as EntityItem<Certificate>).Entity.Id == _newCertificate.Id
                        : false);
            }
            else
            {
                _itemSelectForm.SelectedItem = null;
            }

            if (_itemSelectForm.ShowDialog() == DialogResult.OK)
            {
                var certificateItem = _itemSelectForm.SelectedItem as EntityItem<Certificate>;
                _newCertificate = certificateItem == null ? null : certificateItem.Entity;
            }
        }
    }
}
