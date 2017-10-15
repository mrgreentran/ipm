using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Positions
    {
        public Positions()
        {
            Candidates = new HashSet<Candidates>();
            InterviewProcesses = new HashSet<InterviewProcesses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }

        public ICollection<Candidates> Candidates { get; set; }
        public ICollection<InterviewProcesses> InterviewProcesses { get; set; }
    }
}
