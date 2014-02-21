namespace EnterpriseTraining.Entities
{
    public interface IEntityFactory<T>
        where T : class, IEntity
    {
        T CreateNew();
    }
}
