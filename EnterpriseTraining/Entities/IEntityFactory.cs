namespace EnterpriseTraining.Entities
{
    public interface IEntityFactory<T>
    {
        T CreateNew();
    }
}
