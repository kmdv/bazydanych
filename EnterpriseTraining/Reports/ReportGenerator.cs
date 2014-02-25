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
                        string fullName = ReadFullName(reader, 0, 1);
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
                        string fullName = ReadFullName(reader, 0, 1);
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

        public IList<Tuple<string, string>> GetAllTrainees(ISession session)
        {
            const string QueryText =
                "SELECT FirstName, LastName, T2.Name FROM Users U " +
                "INNER JOIN Trainees T1 ON T1.UserId = U.UserId " +
                "INNER JOIN Trainings T2 ON T2.TrainingId = T1.TrainingId";

            using (var query = session.CreateQuery(QueryText))
            {
                using (var reader = query.ExecuteReader())
                {
                    var results = new List<Tuple<string, string>>();

                    while (reader.Read())
                    {
                        string fullName = ReadFullName(reader, 0, 1);
                        string trainingName = reader.GetString(2);

                        results.Add(new Tuple<string, string>(fullName, trainingName));
                    }

                    return results;
                }
            }
        }

        public IList<Tuple<string, string>> GetAllTrainers(ISession session)
        {
            const string QueryText =
                "SELECT FirstName, LastName, T2.Name FROM Users U " +
                "INNER JOIN Trainers T1 ON T1.UserId = U.UserId " +
                "INNER JOIN Trainings T2 ON T2.TrainingId = T1.TrainingId";

            using (var query = session.CreateQuery(QueryText))
            {
                using (var reader = query.ExecuteReader())
                {
                    var results = new List<Tuple<string, string>>();

                    while (reader.Read())
                    {
                        string fullName = ReadFullName(reader, 0, 1);
                        string trainingName = reader.GetString(2);

                        results.Add(new Tuple<string, string>(fullName, trainingName));
                    }

                    return results;
                }
            }
        }

        public IList<string> GetUsersWhichAreTrainerAndTrainee(ISession session)
        {
            const string QueryText =
                "SELECT FirstName, LastName FROM Users U " +

                "WHERE U.UserId IN (SELECT DISTINCT T1.UserId FROM Trainees T1, Trainers T2 WHERE T1.UserId = T2.UserId)";

            using (var query = session.CreateQuery(QueryText))
            {
                using (var reader = query.ExecuteReader())
                {
                    var results = new List<string>();

                    while (reader.Read())
                    {
                        results.Add(ReadFullName(reader, 0, 1));
                    }

                    return results;
                }
            }
        }

        private string ReadFullName(SqlDataReader reader, int firstName, int lastName)
        {
            return _optionalCellReader.ReadString(reader, firstName) + " " + _optionalCellReader.ReadString(reader, lastName);
        }
    }
}
