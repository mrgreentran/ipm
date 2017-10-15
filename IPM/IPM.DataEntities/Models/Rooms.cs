using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Rooms
    {
        public Rooms()
        {
            MeetingRequests = new HashSet<MeetingRequests>();
        }

        public int RoomId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<MeetingRequests> MeetingRequests { get; set; }
    }
}
