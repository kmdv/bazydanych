namespace EnterpriseTraining.EntityManagement
{
    public interface IEntityEditForm<T>
    {
        T Entity { get; set; }
    }
}
