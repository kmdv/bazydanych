namespace EnterpriseTraining.EntityManagement
{
    public interface IEntityNameFactory<T>
    {
        string Create(T entity);
    }
}
