using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class MeetingRequests
    {
        public int Id { get; set; }
        public string InterviewerEmail { get; set; }
        public string Subject { get; set; }
        public int RoomId { get; set; }
        public string EmailContent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InterviewAdmin { get; set; }
        public string AppointmentId { get; set; }
        public bool Active { get; set; }
        public int? UserId { get; set; }

        public Rooms Room { get; set; }
        public Users User { get; set; }
    }
}
