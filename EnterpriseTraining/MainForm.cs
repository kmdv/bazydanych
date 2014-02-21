using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;
using EnterpriseTraining.Entities.RowReading;
using EnterpriseTraining.EntityManagement;
using EnterpriseTraining.FieldEditing;

namespace EnterpriseTraining
{
    public partial class MainForm : Form
    {
        private readonly EditUserForm _editUserForm;

        private readonly EditTrainingForm _editTrainingForm;

        private readonly EditCertificateForm _editCertificateForm = new EditCertificateForm();

        public MainForm(ISessionFactory sessionFactory)
        {
            InitializeComponent();

            var optionalCellReader = new OptionalCellReader();
            var idListStringizer = new IdListStringizer();

            var certificateRowReader = new CertificateRowReader();
            var certificateListQueryReader = new CertificateListQueryReader(certificateRowReader);
            var certificateLoader = new SqlCertificateLoader(certificateListQueryReader);
            var certificateSaver = new SqlCertificateSaver();
            var certificateRemover = new SqlCertificateRemover(idListStringizer);
            var certificateFactory = new DefaultEntityFactory<Certificate>();
            var certificateStringizer = new CertificateStringizer();

            var userRowReader = new UserRowReader(optionalCellReader);
            var userListQueryReader = new UserListQueryReader(userRowReader);
            var userLoader = new SqlUserLoader(userListQueryReader);
            var userSaver = new SqlUserSaver();
            var userRemover = new SqlUserRemover(idListStringizer);
            var userFactory = new DefaultEntityFactory<User>();
            var userStringizer = new UserStringizer();

            var trainingRowReader = new TrainingRowReader();
            var trainingListQueryReader = new TrainingListQueryReader(trainingRowReader);
            var trainingLoader = new SqlTrainingLoader(trainingListQueryReader, userListQueryReader, certificateListQueryReader);
            var trainingSaver = new SqlTrainingSaver();
            var trainingRemover = new SqlTrainingRemover(idListStringizer);
            var trainingFactory = new DefaultEntityFactory<Training>();
            var trainingStringizer = new TrainingStringizer();

            var fieldStringizer = new FieldStringizer();
            var fieldParser = new FieldParser();

            _editUserForm = new EditUserForm(fieldStringizer, fieldParser);

            _editTrainingForm = new EditTrainingForm(
                fieldStringizer,
                fieldParser,
                delegate()
                {
                    using (var session = sessionFactory.Create())
                    {
                        return certificateLoader.LoadAll(session);
                    }
                });

            userManager.ItemEditor = new EntityItemEditor<User, EditUserForm>(_editUserForm, this);
            userManager.ItemFactory = new EntityItemFactory<User>(sessionFactory, userLoader, userFactory, userStringizer);
            userManager.ItemSaver = new EntityItemSaver<User>(sessionFactory, userSaver);
            userManager.ItemRemover = new EntityItemRemover<User>(sessionFactory, userRemover);

            trainingManager.ItemEditor = new EntityItemEditor<Training, EditTrainingForm>(_editTrainingForm, this);
            trainingManager.ItemFactory = new EntityItemFactory<Training>(sessionFactory, trainingLoader, trainingFactory, trainingStringizer);
            trainingManager.ItemSaver = new EntityItemSaver<Training>(sessionFactory, trainingSaver);
            trainingManager.ItemRemover = new EntityItemRemover<Training>(sessionFactory, trainingRemover);

            certificateManager.ItemEditor = new EntityItemEditor<Certificate, EditCertificateForm>(_editCertificateForm, this);
            certificateManager.ItemFactory = new EntityItemFactory<Certificate>(sessionFactory, certificateLoader, certificateFactory, certificateStringizer);
            certificateManager.ItemSaver = new EntityItemSaver<Certificate>(sessionFactory, certificateSaver);
            certificateManager.ItemRemover = new EntityItemRemover<Certificate>(sessionFactory, certificateRemover);
        }
    }
}
