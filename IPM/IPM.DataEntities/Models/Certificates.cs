using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Certificates
    {
        public Certificates()
        {
            CandidateCertificates = new HashSet<CandidateCertificates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ICollection<CandidateCertificates> CandidateCertificates { get; set; }
    }
}
