using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class InterviewAnswers
    {
        public InterviewAnswers()
        {
            AnswerQuestions = new HashSet<AnswerQuestions>();
        }

        public int Id { get; set; }
        public int InterviewId { get; set; }
        public int CatalogId { get; set; }
        public int Mark { get; set; }
        public bool Active { get; set; }

        public Catalogs Catalog { get; set; }
        public Interviews Interview { get; set; }
        public ICollection<AnswerQuestions> AnswerQuestions { get; set; }
    }
}
