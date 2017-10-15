using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Documents
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool Active { get; set; }

        public Candidates Candidate { get; set; }
    }
}
