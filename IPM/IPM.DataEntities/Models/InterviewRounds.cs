using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class InterviewRounds
    {
        public InterviewRounds()
        {
            RoundProcesses = new HashSet<RoundProcesses>();
        }

        public int Id { get; set; }
        public string RoundName { get; set; }
        public string Description { get; set; }
        public int GuidelineId { get; set; }
        public bool Active { get; set; }

        public Guidelines Guideline { get; set; }
        public ICollection<RoundProcesses> RoundProcesses { get; set; }
    }
}
