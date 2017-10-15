using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class UserRoles
    {
        public string Account { get; set; }
        public int RoleId { get; set; }
        public int? UserId { get; set; }

        public Roles Role { get; set; }
        public Users User { get; set; }
    }
}
