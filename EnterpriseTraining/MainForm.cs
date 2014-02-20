using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;

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
            var userRemover = new SqlUserRemover();
            var userFactory = new DefaultUserFactory();

            var userNameFactory = new UserNameFactory();

            userManager.ItemEditor = new EntityItemEditor<User, EditUserForm>(_editUserForm, this);
            userManager.ItemFactory = new EntityItemFactory<User>(connectionFactory, userLoader, userFactory, userNameFactory);
            userManager.ItemSaver = new EntityItemSaver<User>(connectionFactory, userSaver);
            userManager.ItemRemover = new EntityItemRemover<User>(connectionFactory, userRemover);

            /*var userLoader = new SqlUserLoader();
            var userSaver = new SqlUserSaver();
            var userRemover = new SqlEntityRemover("Users", "UserId");

            userManager.ItemEditor = new UserItemEditor(_editUserForm, this);
            userManager.ItemFactory = new UserItemFactory(connectionFactory, userLoader);
            userManager.ItemSaver = new UserItemSaver(connectionFactory, userSaver);
            userManager.ItemRemover = new UserItemRemover(connectionFactory, userRemover);*/
        }
    }
}
