using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Users
    {
        public Users()
        {
            Candidates = new HashSet<Candidates>();
            InterviewsInterviewAdmin = new HashSet<Interviews>();
            InterviewsInterviewer = new HashSet<Interviews>();
            MeetingRequests = new HashSet<MeetingRequests>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string Account { get; set; }
        public string Username { get; set; }
        public bool Active { get; set; }

        public ICollection<Candidates> Candidates { get; set; }
        public ICollection<Interviews> InterviewsInterviewAdmin { get; set; }
        public ICollection<Interviews> InterviewsInterviewer { get; set; }
        public ICollection<MeetingRequests> MeetingRequests { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
