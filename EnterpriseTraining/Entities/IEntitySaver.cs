using EnterpriseTraining.Sql;

namespace EnterpriseTraining.Entities
{
    public interface IEntitySaver<T>
        where T : class, IEntity
    {
        void SaveNew(ISession session, T entity);

        void SaveExisting(ISession session, T entity);
    }
}
