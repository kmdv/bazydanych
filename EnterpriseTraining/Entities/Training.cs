﻿using System;

namespace EnterpriseTraining.Entities
{
    public class Training
    {
        internal int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Cost { get; set; }

        public int CertificateId { get; set; }

        public int RequiredPoints { get; set; }

        public int MaxPoints { get; set; }
    }
}
