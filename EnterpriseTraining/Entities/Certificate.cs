namespace EnterpriseTraining.Entities
{
    public sealed class Certificate
    {
        public Certificate()
        {
            Id = -1;
            Name = string.Empty;
        }

        internal int Id { get; set; }

        public string Name { get; set; }
    }
}
