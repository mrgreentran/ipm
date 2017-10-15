using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Candidates
    {
        public Candidates()
        {
            CandidateCertificates = new HashSet<CandidateCertificates>();
            CandidateSkills = new HashSet<CandidateSkills>();
            Documents = new HashSet<Documents>();
            Interviews = new HashSet<Interviews>();
        }

        public int Id { get; set; }
        public int? InterviewAdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Idcard { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string University { get; set; }
        public string Major { get; set; }
        public string Gpa { get; set; }
        public string Certificate { get; set; }
        public int ConcidentStatus { get; set; }
        public int PositionId { get; set; }
        public bool Active { get; set; }

        public Users InterviewAdmin { get; set; }
        public Positions Position { get; set; }
        public ICollection<CandidateCertificates> CandidateCertificates { get; set; }
        public ICollection<CandidateSkills> CandidateSkills { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<Interviews> Interviews { get; set; }
    }
}
