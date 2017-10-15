using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class CandidateCertificates
    {
        public int CandidateId { get; set; }
        public int CertificateId { get; set; }
        public bool Active { get; set; }

        public Candidates Candidate { get; set; }
        public Certificates Certificate { get; set; }
    }
}
