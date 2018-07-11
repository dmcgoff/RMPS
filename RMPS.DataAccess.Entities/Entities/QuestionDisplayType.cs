using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionDisplayType
    {
        public QuestionDisplayType()
        {
            Questions = new HashSet<Question>();
        }

        public Guid Id { get; set; }
        public Guid QuestionTypeId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Required { get; set; }
        public string RegexValidator { get; set; }
        public string RegexError { get; set; }

        public QuestionType QuestionType { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
