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
            var sqlContext = new DefaultSqlContext(ConnectionString);
            var entitySaver = new DefaultEntitySaver();
            var entityLoader = new DefaultEntityLoader();
            var entityRemover = new DefaultEntityRemover();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm(sqlContext, entityLoader, entitySaver, entityRemover);

            Application.Run(mainForm);
        }
    }
}
