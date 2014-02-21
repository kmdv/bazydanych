using System;
using System.Data;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public sealed class SqlCertificateSaver : IEntitySaver<Certificate>
    {
        private const string InsertStatement =
            "INSERT INTO Certificates (Name) " +
            "VALUES (@Name)" +
            "SET @Id = SCOPE_IDENTITY()";

        private const string UpdateStatement =
            "UPDATE Certificates SET " +
            "Name=@Name " +
            "WHERE CertificateId=@Id";

        public void SaveNew(ISession session, Certificate certificate)
        {
            using (var command = session.CreateCommand(InsertStatement))
            {
                AddCommonFields(command, certificate);

                command.Parameters.Add("@Id", SqlDbType.Int, 0, "CertificateId").Direction = ParameterDirection.Output;

                EnableNullValues(command);

                command.ExecuteNonQuery();

                SetNewId(command, certificate);
            }
        }

        public void SaveExisting(ISession session, Certificate user)
        {
            using (var command = session.CreateCommand(UpdateStatement))
            {
                AddCommonFields(command, user);
                
                command.Parameters.Add(new SqlParameter("@Id", user.Id));

                EnableNullValues(command);

                command.ExecuteNonQuery();
            }
        }

        private void AddCommonFields(SqlCommand command, Certificate user)
        {
            command.Parameters.Add(new SqlParameter("@Name", user.Name));
        }

        private void EnableNullValues(SqlCommand command)
        {
            foreach (SqlParameter parameter in command.Parameters)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = DBNull.Value;
                }
            }
        }

        private void SetNewId(SqlCommand command, Certificate user)
        {
            user.Id = (int)command.Parameters["@Id"].Value;
        }
    }
}
