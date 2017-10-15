using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Roles
    {
        public Roles()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
