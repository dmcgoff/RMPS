using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionnaireVersionQuestionGroup
    {
        public QuestionnaireVersionQuestionGroup()
        {
            Questions = new HashSet<Question>();
        }

        public Guid Id { get; set; }
        public Guid QuestionnaireVersionId { get; set; }
        public string Text { get; set; }
        public Guid ChangedById { get; set; }
        public string Explanation { get; set; }

        public QuestionnaireVersion QuestionnaireVersion { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
