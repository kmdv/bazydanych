using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using EnterpriseTraining.Entities.RowReading;
using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public class SqlTrainingLoader : IEntityLoader<Training>
    {
        private const string SelectStatement =
            "SELECT TrainingId, Name, Description, StartDate, EndDate, " +
            "Cost, CertificateId, RequiredPoints, MaxPoints FROM Trainings";

        private const string SelectCertificateStatement =
            "SELECT CertificateName FROM Certificates C " +
            "WHERE C.CertificateId = @CertificateId";

        private const string SelectTraineesStatement =
            "SELECT U.UserId, FirstName, LastName, BirthDate, EmailAddress, Country, " +
                "City, Street, HouseNumber, FlatNumber, PostCode FROM Users U " +
            "INNER JOIN Trainees T1 ON T1.UserId = U.UserId " +
            "INNER JOIN Trainings T2 ON T2.TrainingId = T1.TrainingId";

        private const string SelectTrainersStatement =
             "SELECT U.UserId, FirstName, LastName, BirthDate, EmailAddress, Country, " +
                "City, Street, HouseNumber, FlatNumber, PostCode FROM Users U " +
            "INNER JOIN Trainers T1 ON T1.UserId = U.UserId " +
            "INNER JOIN Trainings T2 ON T2.TrainingId = T1.TrainingId";

        private readonly ITrainingListQueryReader _listQueryReader;

        private readonly IUserListQueryReader _userListQueryReader;

        private readonly ICertificateListQueryReader _certificateListQueryReader;

        public SqlTrainingLoader(
            ITrainingListQueryReader listQueryReader,
            IUserListQueryReader userListQueryReader,
            ICertificateListQueryReader certificateListQueryReader)
        {
            _listQueryReader = listQueryReader;
            _userListQueryReader = userListQueryReader;
            _certificateListQueryReader = certificateListQueryReader;
        }

        public IList<Training> LoadAll(ISession session)
        {
            using (var query = session.CreateQuery(SelectStatement))
            {
                var trainings = _listQueryReader.Read(query);
                foreach (var training in trainings)
                {
                    training.Certificate = LoadCertificate(session, 
                    training.Trainees = LoadTrainees(session, training.Id);
                    training.Trainers = LoadTrainers(session, training.Id);
                }

                return trainings;
            }
        }

        private Certificate LoadCertificate(ISession session, int certificateId)
        {
            using (var query = session.CreateQuery(SelectCertificateStatement))
            {
                query.Parameters.Add(new SqlParameter("@CertificateId", certificateId));

                return _certificateListQueryReader.Read(query).FirstOrDefault();
            }
        }

        private IList<User> LoadTrainees(ISession session, int trainingId)
        {
            using (var query = session.CreateQuery(SelectTraineesStatement))
            {
                return _userListQueryReader.Read(query);
            }
        }

        private IList<User> LoadTrainers(ISession session, int trainingId)
        {
            using (var query = session.CreateQuery(SelectTrainersStatement))
            {
                return _userListQueryReader.Read(query);
            }
        }
    }
}
