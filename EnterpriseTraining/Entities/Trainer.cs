namespace EnterpriseTraining.Entities
{
    public class Trainer : IEntity
    {
        public Trainer()
        {
            Id = -1;
        }

        public int Id { get; set; }

        public User User { get; set; }
    }
}
