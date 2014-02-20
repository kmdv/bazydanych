using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;
using EnterpriseTraining.UserManagement;

namespace EnterpriseTraining
{
    public partial class MainForm : Form
    {
        private readonly EditUserForm _editUserForm = new EditUserForm();

        public MainForm(ISqlConnectionFactory connectionFactory)
        {
            InitializeComponent();

            var userLoader = new SqlUserLoader();
            var userSaver = new SqlUserSaver();
            var userRemover = new SqlEntityRemover("Users", "UserId");

            listManager1.ItemEditor = new UserItemEditor(_editUserForm, this);
            listManager1.ItemFactory = new UserItemFactory(connectionFactory, userLoader);
            listManager1.ItemSaver = new UserItemSaver(connectionFactory, userSaver);
            listManager1.ItemRemover = new UserItemRemover(connectionFactory, userRemover);
        }
    }
}
