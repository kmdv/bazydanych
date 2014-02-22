using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;
using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;

namespace EnterpriseTraining.Reports
{
    public sealed class ReportGenerator : IReportGenerator
    {
        private readonly IOptionalCellReader _optionalCellReader = new OptionalCellReader();

        public IList<Tuple<string, int>> GetUsersWithMostCertificates(ISession session, int maxResults)
        {
            const string QueryText =
                "SELECT TOP (@MaxResults) FirstName, LastName, CertificateCount FROM Users U " +
                "INNER JOIN " +
                    "(SELECT UserId, COUNT(CertificateId) AS CertificateCount " +
                        "FROM UserCertificates " +
                        "GROUP BY UserId) " +
                    "C ON C.UserId = U.UserId " +
                "ORDER BY CertificateCount DESC";

            using (var query = session.CreateQuery(QueryText))
            {
                query.Parameters.Add(new SqlParameter("@MaxResults", maxResults));

                using (var reader = query.ExecuteReader())
                {
                    var results = new List<Tuple<string, int>>();

                    while (reader.Read())
                    {
                        string fullName = _optionalCellReader.ReadString(reader, 0) + " " + _optionalCellReader.ReadString(reader, 1);
                        int certificateCount = reader.GetInt32(2);

                        results.Add(new Tuple<string, int>(fullName, certificateCount));
                    }

                    return results;
                }
            }
        }

        public IList<Tuple<string, int>> GetMostActiveTrainees(ISession session, int minTrainingCount)
        {
            const string QueryText =
                "SELECT FirstName, LastName, TrainingCount FROM Users U " +
                "INNER JOIN " +
                    "(SELECT UserId, COUNT(TrainingId) AS TrainingCount " +
                        "FROM Trainees " +
                        "GROUP BY UserId " +
                        "HAVING COUNT(TrainingId) >= (@MinTrainingCount)) " +
                    "C ON C.UserId = U.UserId " +
                "ORDER BY TrainingCount DESC";

            using (var query = session.CreateQuery(QueryText))
            {
                query.Parameters.Add(new SqlParameter("@MinTrainingCount", minTrainingCount));
                using (var reader = query.ExecuteReader())
                {
                    var results = new List<Tuple<string, int>>();

                    while (reader.Read())
                    {
                        string fullName = _optionalCellReader.ReadString(reader, 0) + " " + _optionalCellReader.ReadString(reader, 1);
                        int trainingCount = reader.GetInt32(2);

                        results.Add(new Tuple<string, int>(fullName, trainingCount));
                    }

                    return results;
                }
            }
        }

        public IList<Tuple<string, decimal>> GetTrainingsByCost(ISession session)
        {
            const string QueryText = "SELECT Name, Cost FROM Trainings ORDER BY Cost DESC, Name ASC";

            using (var query = session.CreateQuery(QueryText))
            {
                using (var reader = query.ExecuteReader())
                {
                    var results = new List<Tuple<string, decimal>>();

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        decimal cost = reader.GetDecimal(1);

                        results.Add(new Tuple<string, decimal>(name, cost));
                    }

                    return results;
                }
            }
        }

        public IList<Tuple<string, int>> GetAvailableCertificates(ISession session)
        {
            const string QueryText = "SELECT Name, ValidityYears FROM Certificates ORDER BY Name";

            using (var query = session.CreateQuery(QueryText))
            {
                using (var reader = query.ExecuteReader())
                {
                    var results = new List<Tuple<string, int>>();

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        int validityYears = reader.GetInt32(1);

                        results.Add(new Tuple<string, int>(name, validityYears));
                    }

                    return results;
                }
            }
        }
    }
}
