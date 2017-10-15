using System;
using System.Collections.Generic;

namespace IPM.DataEntities.Models
{
    public partial class AnswerQuestions
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int InterviewAnswerId { get; set; }
        public string CandidateAnswer { get; set; }
        public string Comment { get; set; }
        public bool Active { get; set; }

        public InterviewAnswers InterviewAnswer { get; set; }
        public Questions Question { get; set; }
    }
}
