using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class CandidateSkills
    {
        public int CandidateId { get; set; }
        public int SkillId { get; set; }
        public bool Active { get; set; }

        public Candidates Candidate { get; set; }
        public Skills Skill { get; set; }
    }
}
