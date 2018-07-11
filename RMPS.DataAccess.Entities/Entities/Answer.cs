using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Answer
    {
        public Answer()
        {
            QuestionAnswerConditions = new HashSet<QuestionAnswerCondition>();
            UserAnswers = new HashSet<UserAnswer>();
        }

        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Sequence { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }

        public Question Question { get; set; }
        public ICollection<QuestionAnswerCondition> QuestionAnswerConditions { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
