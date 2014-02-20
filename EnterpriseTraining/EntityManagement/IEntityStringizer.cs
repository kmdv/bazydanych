namespace EnterpriseTraining.EntityManagement
{
    public interface IEntityStringizer<T>
        where T : class
    {
        string Stringize(T entity);
    }
}
