using System;
using System.Windows.Forms;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining
{
    static class Program
    {
        private const string ConnectionString =
            "Data Source=(local);" +
            "Initial Catalog=EnterpriseTraining;" +
            "Integrated Security=SSPI;";

        [STAThread]
        static void Main()
        {
            var sqlConnectionFactory = new SessionFactory(ConnectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm(sqlConnectionFactory);

            Application.Run(mainForm);
        }
    }
}
