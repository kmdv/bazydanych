namespace EnterpriseTraining.Entities
{
    public class DefaultUserFactory : IEntityFactory<User>
    {
        public User CreateNew()
        {
            return new User { Id = -1 };
        }
    }
}
