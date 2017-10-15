using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Catalogs
    {
        public Catalogs()
        {
            CatalogQuestions = new HashSet<CatalogQuestions>();
            GuidelineCatalogs = new HashSet<GuidelineCatalogs>();
            InterviewAnswers = new HashSet<InterviewAnswers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPoint { get; set; }
        public bool Active { get; set; }

        public ICollection<CatalogQuestions> CatalogQuestions { get; set; }
        public ICollection<GuidelineCatalogs> GuidelineCatalogs { get; set; }
        public ICollection<InterviewAnswers> InterviewAnswers { get; set; }
    }
}
