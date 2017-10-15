using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class GuidelineCatalogs
    {
        public int GuidelineId { get; set; }
        public int CatalogId { get; set; }
        public bool Active { get; set; }
        public int Id { get; set; }

        public Catalogs Catalog { get; set; }
        public Guidelines Guideline { get; set; }
    }
}
