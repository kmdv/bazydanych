using System;
using System.Collections.Generic;

namespace EnterpriseTraining.Entities
{
    public sealed class User : IEntity
    {
        public User()
        {
            Id = -1;
            BirthDate = DateTime.Now;
            Certificates = new List<Certificate>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string EmailAddress { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public int? HouseNumber { get; set; }
        public int? FlatNumber { get; set; }

        public string PostCode { get; set; }

        public IList<Certificate> Certificates { get; set; }
    }
}
