using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.ErrorHandling;
using EnterpriseTraining.Entities;
using EnterpriseTraining.Entities.RowReading;
using EnterpriseTraining.EntityManagement;
using EnterpriseTraining.FieldEditing;
using EnterpriseTraining.ItemManagement;
using EnterpriseTraining.Entities.Sql;
using EnterpriseTraining.Reports;

namespace EnterpriseTraining
{
    public partial class MainForm : Form
    {
        private readonly ISessionFactory _sessionFactory;

        private readonly IReportGenerator _reportGenerator;

        private TextReader _printedFile;

        public MainForm(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;

            InitializeComponent();

            var fieldStringizer = new FieldStringizer();
            var fieldParser = new FieldParser();

            var optionalCellReader = new OptionalCellReader();
            var idListStringizer = new IdListStringizer();

            var editCertificateForm = new EditCertificateForm(fieldStringizer, fieldParser);

            var certificateRowReader = new CertificateRowReader();
            var certificateListReader = new CertificateListReader(certificateRowReader);

            var certificateLoader = EntityLoader<Certificate>.CreateForTable(
                idListStringizer,
                certificateListReader,
                "Certificates",
                "CertificateId",
                "Name, ValidityYears");

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

            _reportGenerator = new ReportGenerator();
        }

        private void queryButton1_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                PrintReportToScreen(this.PrintQuery1);
            });
        }

        private void queryButton2_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                PrintReportToScreen(this.PrintQuery2);
            });
        }

        private void queryButton3_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                PrintReportToScreen(this.PrintQuery3);
            });
        }

        private void queryButton4_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                PrintReportToScreen(this.PrintQuery4);
            });
        }

        private void queryButton5_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                PrintReportToScreen(this.PrintQuery5);
            });
        }

        private void queryButton6_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                PrintReportToScreen(this.PrintQuery6);
            });
        }

        private void queryButton7_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                PrintReportToScreen(this.PrintQuery7);
            });
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                if (printDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var reportStream = new MemoryStream();

                    using (var session = _sessionFactory.Create())
                    {
                        PrintReport(new StreamWriter(reportStream), session);
                    }

                    reportStream.Seek(0, SeekOrigin.Begin);

                    _printedFile = new StreamReader(reportStream);

                    printDocument.Print();
                }
            });
        }

        private void printToFileButton_Click(object sender, System.EventArgs e)
        {
            ExceptionHandler.Invoke(this, delegate()
            {
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    PrintReportToFile(saveFileDialog.FileName);
                }
            });
        }

        private delegate void PrintQueryDelegate(TextWriter writer, ISession session);

        private void PrintReportToScreen(PrintQueryDelegate printQuery)
        {
            using (var writer = new StringWriter())
            {
                using (var session = _sessionFactory.Create())
                {
                    printQuery(writer, session);
                }

                MessageBox.Show(writer.ToString(), "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintReportToFile(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(fs))
                {
                    using (var session = _sessionFactory.Create())
                    {
                        PrintReport(writer, session);
                    }
                }
            }
        }

        private void PrintReport(TextWriter writer, ISession session)
        {
            writer.WriteLine("--------------------------------------------------------------------------------");
            writer.WriteLine("Enterprise Training Report");
            writer.WriteLine("Date: {0}", DateTime.UtcNow.ToShortDateString());
            writer.WriteLine("--------------------------------------------------------------------------------");
            writer.WriteLine();
            writer.WriteLine("Top 5 users with highest number of certifices:");

            PrintQuery1(writer, session);

            writer.WriteLine();
            writer.WriteLine("Top 5 most active trainees (with at least 3 trainings):");

            PrintQuery2(writer, session);

            writer.WriteLine();
            writer.WriteLine("Trainings by cost:");

            PrintQuery3(writer, session);

            writer.WriteLine();
            writer.WriteLine("Available certificates:");

            PrintQuery4(writer, session);

            writer.WriteLine();
            writer.WriteLine("All trainees:");

            PrintQuery5(writer, session);

            writer.WriteLine();
            writer.WriteLine("All trainers:");

            PrintQuery6(writer, session);

            writer.WriteLine();
            writer.WriteLine("Users which are trainers AND trainees:");

            PrintQuery7(writer, session);
        }

        private void PrintQuery7(TextWriter writer, ISession session)
        {
            foreach (var result in _reportGenerator.GetUsersWhichAreTrainerAndTrainee(session))
            {
                writer.WriteLine(result);
            }
        }

        private void PrintQuery6(TextWriter writer, ISession session)
        {
            foreach (var result in _reportGenerator.GetAllTrainers(session))
            {
                writer.WriteLine("{0} - {1}", result.Item1, result.Item2);
            }
        }

        private void PrintQuery5(TextWriter writer, ISession session)
        {
            foreach (var result in _reportGenerator.GetAllTrainees(session))
            {
                writer.WriteLine("{0} - {1}", result.Item1, result.Item2);
            }
        }

        private void PrintQuery4(TextWriter writer, ISession session)
        {
            foreach (var result in _reportGenerator.GetAvailableCertificates(session))
            {
                writer.WriteLine("{0} - {1} year(s)", result.Item1, result.Item2);
            }
        }

        private void PrintQuery3(TextWriter writer, ISession session)
        {
            foreach (var result in _reportGenerator.GetTrainingsByCost(session))
            {
                writer.WriteLine("{0:c} - {1}", result.Item2, result.Item1);
            }
        }

        private void PrintQuery2(TextWriter writer, ISession session)
        {
            foreach (var result in _reportGenerator.GetMostActiveTrainees(session, 3))
            {
                writer.WriteLine("{0} training(s) - {1}", result.Item2, result.Item1);
            }
        }

        private void PrintQuery1(TextWriter writer, ISession session)
        {
            foreach (var result in _reportGenerator.GetUsersWithMostCertificates(session, 5))
            {
                writer.WriteLine("{0} certificate(s) - {1}", result.Item2, result.Item1);
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var printFont = new Font("Arial", 10);

            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = _printedFile.ReadLine();
                if (line == null)
                {
                    break;
                }

                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }

            if (line != null)
            {
                e.HasMorePages = true;
            }
        }
    }
}
