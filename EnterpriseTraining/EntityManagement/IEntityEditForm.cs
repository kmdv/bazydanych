using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public interface IEntityEditForm<T>
        where T : class, IEntity
    {
        T Entity { get; set; }
    }
}
