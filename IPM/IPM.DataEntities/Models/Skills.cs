using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Skills
    {
        public Skills()
        {
            CandidateSkills = new HashSet<CandidateSkills>();
            Questions = new HashSet<Questions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public int? TotalRow { get; set; }

        public ICollection<CandidateSkills> CandidateSkills { get; set; }
        public ICollection<Questions> Questions { get; set; }
    }
}
