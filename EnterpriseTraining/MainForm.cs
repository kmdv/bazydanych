using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;
using EnterpriseTraining.Entities.RowReading;
using EnterpriseTraining.EntityManagement;
using EnterpriseTraining.FieldEditing;
using EnterpriseTraining.ItemManagement;
using EnterpriseTraining.Entities.Sql;

namespace EnterpriseTraining
{
    public partial class MainForm : Form
    {
        public MainForm(ISessionFactory sessionFactory)
        {
            InitializeComponent();

            var fieldStringizer = new FieldStringizer();
            var fieldParser = new FieldParser();

            var optionalCellReader = new OptionalCellReader();
            var idListStringizer = new IdListStringizer();

            var editCertificateForm = new EditCertificateForm();

            var certificateRowReader = new CertificateRowReader();
            var certificateListReader = new CertificateListReader(certificateRowReader);

            var certificateLoader = EntityLoader<Certificate>.CreateForTable(
                idListStringizer,
                certificateListReader,
                "Certificates",
                "CertificateId",
                "Name");

            var certificateSaver = new CertificateSaver();

            var certificateRemover = EntityRemover<Certificate>.CreateForTable(
                idListStringizer,
                "Certificates",
                "CertificateId");

            var certificateFactory = new DefaultEntityFactory<Certificate>();
            var certificateStringizer = new CertificateStringizer();

            var certificateItemEditor = new EntityItemEditor<Certificate, EditCertificateForm>(editCertificateForm, this);
            var certificateItemFactory = new EntityItemFactory<Certificate>(sessionFactory, certificateLoader, certificateFactory, certificateStringizer);
            var certificateItemSaver = new EntityItemSaver<Certificate>(sessionFactory, certificateSaver);
            var certificateItemRemover = new EntityItemRemover<Certificate>(sessionFactory, certificateRemover);

            var userCertificatesLoader = new UserCertificatesLoader(certificateListReader);
            var userRowReader = new UserRowReader(optionalCellReader);
            var userListReader = new UserListReader(userRowReader, userCertificatesLoader);
            var userLoader = EntityLoader<User>.CreateForTable(
                idListStringizer,
                userListReader,
                "Users",
                "UserId",
                "FirstName, LastName, BirthDate, EmailAddress, Country, City, Street, HouseNumber, FlatNumber, PostCode");

            var innerUserSaver = new UserSaver();
            var userCertificatesSaver = new UserCertificatesSaver(innerUserSaver);
            var userSaver = userCertificatesSaver;

            var innerUserRemover = EntityRemover<User>.CreateForTable(
                idListStringizer,
                "Users",
                "UserId");
            var userCertificatesRemover = new UserCertificatesRemover(idListStringizer, innerUserRemover);
            var userRemover = userCertificatesRemover;

            var editUserForm = new EditUserForm(fieldStringizer, fieldParser, certificateItemFactory);

            var userFactory = new DefaultEntityFactory<User>();
            var userStringizer = new UserStringizer();

            var userItemEditor = new EntityItemEditor<User, EditUserForm>(editUserForm, this);
            var userItemFactory = new EntityItemFactory<User>(sessionFactory, userLoader, userFactory, userStringizer);
            var userItemSaver = new EntityItemSaver<User>(sessionFactory, userSaver);
            var userItemRemover = new EntityItemRemover<User>(sessionFactory, userRemover);

            var traineesLoader = new TrainingTraineesLoader(userListReader);
            var trainersLoader = new TrainingTrainersLoader(userListReader);

            var trainingRowReader = new TrainingRowReader();
            var trainingListReader = new TrainingListReader(trainingRowReader, certificateLoader, traineesLoader, trainersLoader);
            var trainingLoader = EntityLoader<Training>.CreateForTable(
                idListStringizer,
                trainingListReader,
                "Trainings",
                "TrainingId",
                "Name, Description, StartDate, EndDate, Cost, CertificateId, RequiredPoints, MaxPoints");

            var innerTrainingSaver = new TrainingSaver();
            var traineesSaver = new TrainingTraineesSaver(innerTrainingSaver);
            var trainersSaver = new TrainingTrainersSaver(traineesSaver);
            var trainingSaver = trainersSaver;

            var innerTrainingRemover = EntityRemover<Training>.CreateForTable(idListStringizer, "Trainings", "TrainingId");
            var traineesRemover = new TrainingTraineesRemover(idListStringizer, innerTrainingRemover);
            var trainersRemover = new TrainingTrainersRemover(idListStringizer, traineesRemover);
            var trainingRemover = trainersRemover;

            var trainingFactory = new DefaultEntityFactory<Training>();
            var trainingStringizer = new TrainingStringizer();

            var itemSelectForm = new ItemSelectForm();

            var editTrainingForm = new EditTrainingForm(
                fieldStringizer,
                fieldParser,
                itemSelectForm,
                userItemFactory,
                certificateItemFactory);

            userManager.ItemEditor = userItemEditor;
            userManager.ItemFactory = userItemFactory;
            userManager.ItemSaver = userItemSaver;
            userManager.ItemRemover = userItemRemover;

            trainingManager.ItemEditor = new EntityItemEditor<Training, EditTrainingForm>(editTrainingForm, this);
            trainingManager.ItemFactory = new EntityItemFactory<Training>(sessionFactory, trainingLoader, trainingFactory, trainingStringizer);
            trainingManager.ItemSaver = new EntityItemSaver<Training>(sessionFactory, trainingSaver);
            trainingManager.ItemRemover = new EntityItemRemover<Training>(sessionFactory, trainingRemover);

            certificateManager.ItemEditor = certificateItemEditor;
            certificateManager.ItemFactory = certificateItemFactory;
            certificateManager.ItemSaver = certificateItemSaver;
            certificateManager.ItemRemover = certificateItemRemover;
        }
    }
}
