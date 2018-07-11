using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ClientCurriculumPlanQuestionnaireOverride
    {
        public Guid Id { get; set; }
        public Guid ClientCurriculumPlanId { get; set; }
        public bool AllowViewingPassedTests { get; set; }
        public bool AllowViewingFailedTests { get; set; }
        public bool AllowViewingScore { get; set; }
        public bool AllowViewingAnswersWhenFailed { get; set; }
        public int NumberOfTries { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public bool AllowViewingExplanation { get; set; }

        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
    }
}
