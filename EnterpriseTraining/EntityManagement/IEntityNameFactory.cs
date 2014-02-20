namespace EnterpriseTraining.EntityManagement
{
    public interface IEntityNameFactory<T>
        where T : class
    {
        string Create(T entity);
    }
}
