using System;
using System.IO;
using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining
{
    static class Program
    {
        private const string ConnectionStringFileName = @"\ConnectionString.txt";

        private const string DefaultConnectionString =
            "MultipleActiveResultSets=True;" +
            "Data Source=(local);" +
            "Initial Catalog=EnterpriseTraining;" +
            "Integrated Security=SSPI;";

        [STAThread]
        static void Main(string[] args)
        {
            var sessionFactory = new SessionFactory(GetConnectionString(args));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm(sessionFactory);

            Application.Run(mainForm);
        }

        private static string GetConnectionString(string[] args)
        {
            if (args.Length > 0)
            {
                MessageBox.Show(
                    string.Format("Connection string has been changed to:\r\n{0}", args[0]),
                    "Connection string changed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return args[0];
            }

            var connectionString = TryToReadConnectionStringFromFile();
            if (connectionString != null)
            {
                return connectionString;
            }

            return DefaultConnectionString;
        }

        private static string TryToReadConnectionStringFromFile()
        {
            try
            {
                string fileName = Path.GetDirectoryName(Application.ExecutablePath) + ConnectionStringFileName;

                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(fs))
                    {
                        return reader.ReadLine();
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
