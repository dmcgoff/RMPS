using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionType
    {
        public QuestionType()
        {
            QuestionDisplayTypes = new HashSet<QuestionDisplayType>();
            Questions = new HashSet<Question>();
        }

        public string Name { get; set; }
        public bool AnswerRequired { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Type { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<QuestionDisplayType> QuestionDisplayTypes { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
