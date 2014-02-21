using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public interface IEntityStringizer<T>
        where T : class, IEntity
    {
        string Stringize(T entity);
    }
}
