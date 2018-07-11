using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserCurriculum
    {
        public int RowNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClientName { get; set; }
        public string DepartmentName { get; set; }
        public string ClientCurriculumName { get; set; }
        public bool? ComplianceOptional { get; set; }
        public string CurriculumTypeName { get; set; }
        public DateTime ContextDate { get; set; }
        public DateTime UsersEffectiveDate { get; set; }
        public DateTime? UsersEndingDate { get; set; }
        public DateTime? ProgramYearStartDate { get; set; }
        public DateTime? ProgramYearEndDate { get; set; }
        public bool IsCurrentProgramYear { get; set; }
        public bool IsPastProgramYear { get; set; }
        public bool IsFutureProgramYear { get; set; }
        public bool IsTakeAnytime { get; set; }
        public bool? IsPrerequisite { get; set; }
        public int? SequenceNumber { get; set; }
        public string ModalityName { get; set; }
        public string ModalityTypeName { get; set; }
        public string ModalityDescriptorName { get; set; }
        public string ModalityVariantName { get; set; }
        public string Objectives { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string RegisteredVariantName { get; set; }
        public DateTime? EventStartTime { get; set; }
        public string ModalityState { get; set; }
        public string CustomIconPath { get; set; }
        public string ModalityVariantLastStep { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PreRegistrationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? GracePeriodDate { get; set; }
        public Guid UserId { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? UserModalityLogId { get; set; }
        public bool? CoursePassed { get; set; }
        public double? CourseScore { get; set; }
        public bool? PassingScoreRequired { get; set; }
        public Guid? ClientCurriculumPlanId { get; set; }
        public Guid? ClientCurriculumId { get; set; }
        public Guid ClientId { get; set; }
        public Guid? CurriculumTypeId { get; set; }
        public Guid? DepartmentId { get; set; }
        public Guid? EventRegistrationId { get; set; }
        public Guid? ModalityId { get; set; }
        public Guid? ModalityTypeId { get; set; }
        public Guid? UserRoleId { get; set; }
        public Guid? ModalityVariantId { get; set; }
        public Guid? SubstitutedModalityVariantId { get; set; }
        public bool IsOptional { get; set; }
        public Guid? ModalityDescriptorId { get; set; }
        public DateTime? EventEndTime { get; set; }
        public bool IsRecommended { get; set; }
        public Guid? UserClientCurriculumPlanModalitySubstitutionId { get; set; }
        public bool IsRequired { get; set; }

        public Client Client { get; set; }
        public ClientCurriculum ClientCurriculum { get; set; }
        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
        public CurriculumType CurriculumType { get; set; }
        public Department Department { get; set; }
        public EventRegistration EventRegistration { get; set; }
        public Modality Modality { get; set; }
        public ModalityDescriptor ModalityDescriptor { get; set; }
        public ModalityType ModalityType { get; set; }
        public ModalityVariant ModalityVariant { get; set; }
        public ModalityVariant SubstitutedModalityVariant { get; set; }
        public User User { get; set; }
        public UserClientCurriculumPlanModalitySubstitution UserClientCurriculumPlanModalitySubstitution { get; set; }
        public UserModalityLog UserModalityLog { get; set; }
        public UserRole UserRole { get; set; }
    }
}
