namespace EnterpriseTraining.Entities
{
    public class DefaultEntityFactory<T> : IEntityFactory<T>
        where T : class, IEntity, new()
    {
        public T CreateNew()
        {
            return new T();
        }
    }
}
