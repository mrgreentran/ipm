using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Interviews
    {
        public Interviews()
        {
            InterviewAnswers = new HashSet<InterviewAnswers>();
        }

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int RoundProcessId { get; set; }
        public int CandidateId { get; set; }
        public bool? Result { get; set; }
        public string Record { get; set; }
        public int? InterviewerId { get; set; }
        public int? InterviewAdminId { get; set; }
        public bool Active { get; set; }

        public Candidates Candidate { get; set; }
        public Users InterviewAdmin { get; set; }
        public Users Interviewer { get; set; }
        public RoundProcesses RoundProcess { get; set; }
        public ICollection<InterviewAnswers> InterviewAnswers { get; set; }
    }
}
