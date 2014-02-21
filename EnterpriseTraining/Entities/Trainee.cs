namespace EnterpriseTraining.Entities
{
    public class Trainee : IEntity
    {
        public Trainee()
        {
            Id = -1;
        }

        public int Id { get; set; }

        public User User { get; set; }
    }
}
