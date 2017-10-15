using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class CatalogQuestions
    {
        public int CatalogId { get; set; }
        public int QuestionId { get; set; }
        public bool Active { get; set; }
        public int Id { get; set; }

        public Catalogs Catalog { get; set; }
        public Questions Question { get; set; }
    }
}
