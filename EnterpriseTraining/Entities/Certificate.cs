namespace EnterpriseTraining.Entities
{
    public sealed class Certificate : IEntity
    {
        public Certificate()
        {
            Id = -1;
            Name = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
