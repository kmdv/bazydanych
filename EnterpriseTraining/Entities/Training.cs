using System;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public sealed class Training : IEntity
    {
        public Training()
        {
            Id = -1;
            Name = string.Empty;
            Description = string.Empty;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            Trainers = new List<User>();
            Trainees = new List<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal Cost { get; set; }

        public Certificate Certificate { get; set; }

        public int RequiredPoints { get; set; }
        public int MaxPoints { get; set; }

        public IList<User> Trainers { get; set; }
        public IList<User> Trainees { get; set; }
    }
}
