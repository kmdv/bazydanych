using System;
using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining
{
    static class Program
    {
        private const string ConnectionString =
            "MultipleActiveResultSets=True;" +
            "Data Source=(local);" +
            "Initial Catalog=EnterpriseTraining;" +
            "Integrated Security=SSPI;";

        [STAThread]
        static void Main()
        {
            var sessionFactory = new SessionFactory(ConnectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm(sessionFactory);

            Application.Run(mainForm);
        }
    }
}
