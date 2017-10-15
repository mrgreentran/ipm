using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class InterviewProcesses
    {
        public InterviewProcesses()
        {
            RoundProcesses = new HashSet<RoundProcesses>();
        }

        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int PositionId { get; set; }
        public DateTime StartDate { get; set; }
        public bool Active { get; set; }

        public Positions Position { get; set; }
        public ICollection<RoundProcesses> RoundProcesses { get; set; }
    }
}
