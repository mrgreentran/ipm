using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Guidelines
    {
        public Guidelines()
        {
            GuidelineCatalogs = new HashSet<GuidelineCatalogs>();
            InterviewRounds = new HashSet<InterviewRounds>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<GuidelineCatalogs> GuidelineCatalogs { get; set; }
        public ICollection<InterviewRounds> InterviewRounds { get; set; }
    }
}
