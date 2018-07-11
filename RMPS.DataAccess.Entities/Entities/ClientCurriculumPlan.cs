using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ClientCurriculumPlan
    {
        public ClientCurriculumPlan()
        {
            ClientCurriculumPlanCertificationTypePrices = new HashSet<ClientCurriculumPlanCertificationTypePrice>();
            ClientCurriculumPlanPrerequisiteClientCurriculumPlanPrerequisiteNavigations = new HashSet<ClientCurriculumPlanPrerequisite>();
            ClientCurriculumPlanPrerequisiteClientCurriculumPlans = new HashSet<ClientCurriculumPlanPrerequisite>();
            ClientCurriculumPlanQuestionnaireOverrides = new HashSet<ClientCurriculumPlanQuestionnaireOverride>();
            EventRegistrations = new HashSet<EventRegistration>();
            RiskAlertNotifications = new HashSet<RiskAlertNotification>();
            UserClientCurriculumPlanModalitySubstitutions = new HashSet<UserClientCurriculumPlanModalitySubstitution>();
            UserCurriculums = new HashSet<UserCurriculum>();
            UserModalityLogs = new HashSet<UserModalityLog>();
        }

        public bool IsPrerequisite { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PreRegistrationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? GracePeriodDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public string AudienceExpression { get; set; }
        public bool IsActive { get; set; }
        public bool PassingScoreRequired { get; set; }
        public Guid Id { get; set; }
        public Guid ClientCurriculumId { get; set; }
        public Guid ModalityId { get; set; }
        public bool IsOptional { get; set; }
        public string Comment { get; set; }
        public bool IsRecommended { get; set; }
        public int? DaysAvailableToUser { get; set; }
        public string DaysAvailableToUserNote { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsRequired { get; set; }
        public Guid? CourseGroupingId { get; set; }

        public ClientCurriculum ClientCurriculum { get; set; }
        public CourseGrouping CourseGrouping { get; set; }
        public Modality Modality { get; set; }
        public ICollection<ClientCurriculumPlanCertificationTypePrice> ClientCurriculumPlanCertificationTypePrices { get; set; }
        public ICollection<ClientCurriculumPlanPrerequisite> ClientCurriculumPlanPrerequisiteClientCurriculumPlanPrerequisiteNavigations { get; set; }
        public ICollection<ClientCurriculumPlanPrerequisite> ClientCurriculumPlanPrerequisiteClientCurriculumPlans { get; set; }
        public ICollection<ClientCurriculumPlanQuestionnaireOverride> ClientCurriculumPlanQuestionnaireOverrides { get; set; }
        public ICollection<EventRegistration> EventRegistrations { get; set; }
        public ICollection<RiskAlertNotification> RiskAlertNotifications { get; set; }
        public ICollection<UserClientCurriculumPlanModalitySubstitution> UserClientCurriculumPlanModalitySubstitutions { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserModalityLog> UserModalityLogs { get; set; }
    }
}
