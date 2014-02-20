namespace EnterpriseTraining.EntityManagement
{
    public interface IEntityEditForm<T>
        where T : class
    {
        T Entity { get; set; }
    }
}
