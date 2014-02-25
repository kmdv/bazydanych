using System;
using System.Collections.Generic;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.Reports
{
    public interface IReportGenerator
    {
        IList<Tuple<string, int>> GetUsersWithMostCertificates(ISession session, int maxResults);

        IList<Tuple<string, int>> GetMostActiveTrainees(ISession session, int minTrainingCount);

        IList<Tuple<string, decimal>> GetTrainingsByCost(ISession session);

        IList<Tuple<string, int>> GetAvailableCertificates(ISession session);

        IList<Tuple<string, string>> GetAllTrainees(ISession session);

        IList<Tuple<string, string>> GetAllTrainers(ISession session);

        IList<string> GetUsersWhichAreTrainerAndTrainee(ISession session);
    }
}
