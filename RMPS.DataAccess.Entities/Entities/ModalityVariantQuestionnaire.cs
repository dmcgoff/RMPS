using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantQuestionnaire
    {
        public bool AllowViewingPassedTests { get; set; }
        public bool AllowViewingFailedTests { get; set; }
        public bool AllowViewingScore { get; set; }
        public Guid Id { get; set; }
        public Guid QuestionnaireId { get; set; }
        public Guid QuestionnaireUsageId { get; set; }
        public Guid ModalityVariantId { get; set; }
        public bool AllowViewingAnswersWhenFailed { get; set; }
        public int NumberOfTries { get; set; }
        public bool AllowViewingExplanation { get; set; }

        public ModalityVariant ModalityVariant { get; set; }
        public Questionnaire Questionnaire { get; set; }
        public QuestionnaireUsage QuestionnaireUsage { get; set; }
    }
}
