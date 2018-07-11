using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            QuestionAnswerConditions = new HashSet<QuestionAnswerCondition>();
            UserAnswers = new HashSet<UserAnswer>();
        }

        public string Text { get; set; }
        public int? Sequence { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? QuestionMeasureId { get; set; }
        public bool IsScored { get; set; }
        public Guid? CorrectAnswerId { get; set; }
        public Guid QuestionnaireVersionId { get; set; }
        public Guid Id { get; set; }
        public Guid QuestionTypeId { get; set; }
        public Guid? QuestionGroupId { get; set; }
        public Guid QuestionDisplayTypeId { get; set; }
        public int Weight { get; set; }
        public string Explanation { get; set; }

        public QuestionDisplayType QuestionDisplayType { get; set; }
        public QuestionnaireVersionQuestionGroup QuestionGroup { get; set; }
        public QuestionMeasure QuestionMeasure { get; set; }
        public QuestionType QuestionType { get; set; }
        public QuestionnaireVersion QuestionnaireVersion { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<QuestionAnswerCondition> QuestionAnswerConditions { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
