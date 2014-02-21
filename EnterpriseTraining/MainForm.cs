using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;

namespace EnterpriseTraining
{
    public partial class MainForm : Form
    {
        private readonly EditUserForm _editUserForm = new EditUserForm();

        public MainForm(ISessionFactory sessionFactory)
        {
            InitializeComponent();

            var optionalCellReader = new OptionalCellReader();
            var sqlIdListStringizer = new IdListStringizer();

            var userLoader = new SqlUserLoader(optionalCellReader);
            var userSaver = new SqlUserSaver();
            var userRemover = new SqlUserRemover(sqlIdListStringizer);
            var userFactory = new DefaultUserFactory();

            var userNameFactory = new UserStringizer();

            userManager.ItemEditor = new EntityItemEditor<User, EditUserForm>(_editUserForm, this);
            userManager.ItemFactory = new EntityItemFactory<User>(sessionFactory, userLoader, userFactory, userNameFactory);
            userManager.ItemSaver = new EntityItemSaver<User>(sessionFactory, userSaver);
            userManager.ItemRemover = new EntityItemRemover<User>(sessionFactory, userRemover);
        }
    }
}
