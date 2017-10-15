using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class Questions
    {
        public Questions()
        {
            AnswerQuestions = new HashSet<AnswerQuestions>();
            CatalogQuestions = new HashSet<CatalogQuestions>();
        }

        public int Id { get; set; }
        public int SkillId { get; set; }
        public string Content { get; set; }
        public string Answer { get; set; }
        public bool Active { get; set; }

        public Skills Skill { get; set; }
        public ICollection<AnswerQuestions> AnswerQuestions { get; set; }
        public ICollection<CatalogQuestions> CatalogQuestions { get; set; }
    }
}
