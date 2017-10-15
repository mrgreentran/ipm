using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class SystemParameters
    {
        public int Id { get; set; }
        public string ParaName { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
