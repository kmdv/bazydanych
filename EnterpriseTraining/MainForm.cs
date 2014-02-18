using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;
using System.Data;
using System.Collections.Generic;

namespace EnterpriseTraining
{
    public partial class MainForm : Form
    {
        private readonly ISqlContext _sqlContext;

        private readonly IEntityLoader _entityLoader;

        private readonly IEntitySaver _entitySaver;

        private readonly IEntityRemover _entityRemover;

        private readonly EditUserForm _editForm = new EditUserForm();

        private readonly BindingList<UserListBoxItem> _userList = new BindingList<UserListBoxItem>();

        public MainForm(ISqlContext sqlContext, IEntityLoader entityLoader, IEntitySaver entitySaver, IEntityRemover entityRemover)
        {
            _sqlContext = sqlContext;
            _entityLoader = entityLoader;
            _entitySaver = entitySaver;
            _entityRemover = entityRemover;

            InitializeComponent();

            userListBox.DataSource = _userList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(_sqlContext.ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM Users", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _userList.Add(new UserListBoxItem { User = _entityLoader.LoadUser(reader) });
                        }
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _editForm.User = new User();
            _editForm.StartPosition = FormStartPosition.CenterParent;

            if (_editForm.ShowDialog(this) == DialogResult.OK)
            {
                var user = _editForm.User;

                using (var connection = new SqlConnection(_sqlContext.ConnectionString))
                {
                    connection.Open();

                    user = _entitySaver.SaveNewUser(connection, user);
                }

                _userList.Add(new UserListBoxItem { User = user });
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    "Are you sure you want to remove the selected users?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selectedItems = new List<UserListBoxItem>();
                    var ids = new List<int>();
                    foreach (var item in userListBox.SelectedItems)
                    {
                        selectedItems.Add(((UserListBoxItem)item));
                        ids.Add(((UserListBoxItem)item).User.Id);
                    }

                    using (var connection = new SqlConnection(_sqlContext.ConnectionString))
                    {
                        connection.Open();

                        _entityRemover.RemoveUsers(connection, ids);
                    }

                    foreach (var item in selectedItems)
                    {
                        _userList.Remove(item);
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedIndex >= 0)
            {
                _editForm.User = ((UserListBoxItem)userListBox.SelectedItem).User;
                _editForm.StartPosition = FormStartPosition.CenterParent;

                if (_editForm.ShowDialog(this) == DialogResult.OK)
                {
                    var user = _editForm.User;

                    using (var connection = new SqlConnection(_sqlContext.ConnectionString))
                    {
                        connection.Open();
                        _entitySaver.SaveExistingUser(connection, user);
                    }

                    ((UserListBoxItem)userListBox.SelectedItem).User = user;
                }
            }
        }
    }
}
