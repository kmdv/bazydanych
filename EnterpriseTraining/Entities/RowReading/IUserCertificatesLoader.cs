using System;
using System.Collections.Generic;
using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities.RowReading
{
    public interface IUserCertificatesLoader
    {
        IList<Certificate> Load(ISession session, int userId);
    }
}
