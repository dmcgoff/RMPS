using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionnaireVersion
    {
        public QuestionnaireVersion()
        {
            QuestionnaireVersionQuestionGroups = new HashSet<QuestionnaireVersionQuestionGroup>();
            Questions = new HashSet<Question>();
            UserQuestionnaires = new HashSet<UserQuestionnaire>();
        }

        public int Version { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? PassingScore { get; set; }
        public Guid ChangedById { get; set; }
        public Guid QuestionnaireId { get; set; }
        public Guid QuestionnaireStateId { get; set; }
        public Guid Id { get; set; }

        public Questionnaire Questionnaire { get; set; }
        public QuestionnaireState QuestionnaireState { get; set; }
        public ICollection<QuestionnaireVersionQuestionGroup> QuestionnaireVersionQuestionGroups { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<UserQuestionnaire> UserQuestionnaires { get; set; }
    }
}
