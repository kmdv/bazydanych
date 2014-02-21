﻿using System.Data.SqlClient;

namespace EnterpriseTraining.Entities.Sql
{
    public sealed class CertificateSaver : AbstractEntitySaver<Certificate>
    {
        private const string CustomInsertStatement =
            "INSERT INTO Certificates (Name) " +
            "VALUES (@Name)" +
            "SET @Id = SCOPE_IDENTITY()";

        private const string CustomUpdateStatement =
            "UPDATE Certificates SET " +
            "Name=@Name " +
            "WHERE CertificateId=@Id";

        private const string CustomIdColumnName = "CertificateId";

        private const string CustomIdParameterName = "@Id";

        protected override void AddCommonFields(SqlCommand command, Certificate certificate)
        {
            command.Parameters.Add(new SqlParameter("@Name", certificate.Name));
        }

        protected override string InsertStatement
        {
            get { return CustomInsertStatement; }
        }

        protected override string UpdateStatement
        {
            get { return CustomUpdateStatement; }
        }

        protected override string IdColumnName
        {
            get { return CustomIdColumnName; }
        }

        protected override string IdParameterName
        {
            get { return CustomIdParameterName; }
        }
    }
}
