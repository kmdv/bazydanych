using System;

namespace EnterpriseTraining.Entities
{
    public struct User
    {
        internal int Id { get; set; }

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
    }
}
