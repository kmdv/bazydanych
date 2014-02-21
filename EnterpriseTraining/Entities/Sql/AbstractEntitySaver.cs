using System;
using System.Data;
using System.Data.SqlClient;

using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public abstract class AbstractEntitySaver<T> : IEntitySaver<T>
        where T : class, IEntity
    {
        /*private const string InsertStatement =
            "INSERT INTO Certificates (Name) " +
            "VALUES (@Name)" +
            "SET @Id = SCOPE_IDENTITY()";

        private const string UpdateStatement =
            "UPDATE Certificates SET " +
            "Name=@Name " +
            "WHERE CertificateId=@Id";*/

        public void SaveNew(ISession session, T entity)
        {
            using (var command = session.CreateCommand(InsertStatement))
            {
                AddCommonFields(command, entity);

                command.Parameters.Add(IdParameterName, SqlDbType.Int, 0, IdColumnName).Direction = ParameterDirection.Output;

                EnableNullValues(command);

                command.ExecuteNonQuery();

                entity.Id = GetNewId(command);
            }
        }

        public void SaveExisting(ISession session, T entity)
        {
            using (var command = session.CreateCommand(UpdateStatement))
            {
                AddCommonFields(command, entity);
                
                command.Parameters.Add(new SqlParameter(IdParameterName, entity.Id));

                EnableNullValues(command);

                command.ExecuteNonQuery();
            }
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

        private int GetNewId(SqlCommand command)
        {
            return (int)command.Parameters[IdParameterName].Value;
        }

        protected abstract string InsertStatement { get; }

        protected abstract string UpdateStatement { get; }

        protected abstract string IdColumnName { get; }

        protected abstract string IdParameterName { get; }

        protected abstract void AddCommonFields(SqlCommand command, T entity);
    }
}
