using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class RoundProcesses
    {
        public RoundProcesses()
        {
            Interviews = new HashSet<Interviews>();
        }

        public int Id { get; set; }
        public int InterviewRoundId { get; set; }
        public int InterviewProcessId { get; set; }
        public bool Active { get; set; }
        public int RoundOrder { get; set; }

        public InterviewProcesses InterviewProcess { get; set; }
        public InterviewRounds InterviewRound { get; set; }
        public ICollection<Interviews> Interviews { get; set; }
    }
}
