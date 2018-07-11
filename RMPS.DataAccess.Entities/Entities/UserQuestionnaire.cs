using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class UserQuestionnaire
    {
        public UserQuestionnaire()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }

        public double? Score { get; set; }
        public DateTime? TakenDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid UserModalityLogId { get; set; }
        public Guid QuestionnaireUsageId { get; set; }
        public Guid QuestionnaireVersionId { get; set; }
        public Guid Id { get; set; }
        public Guid? UserQuestionnaireStatusTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public bool IsOverride { get; set; }

        public QuestionnaireUsage QuestionnaireUsage { get; set; }
        public QuestionnaireVersion QuestionnaireVersion { get; set; }
        public UserModalityLog UserModalityLog { get; set; }
        public UserQuestionnaireStatusType UserQuestionnaireStatusType { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
