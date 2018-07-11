using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class UserModalityLog
    {
        public UserModalityLog()
        {
            CertificateRequests = new HashSet<CertificateRequest>();
            UserCurriculums = new HashSet<UserCurriculum>();
            UserQuestionnaires = new HashSet<UserQuestionnaire>();
        }

        public DateTime StartedTime { get; set; }
        public DateTime? EndedTime { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double TimeZoneOffset { get; set; }
        public string AdditionalStepInfo { get; set; }
        public string LastStep { get; set; }
        public Guid UserId { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid? ClientCurriculumPlanId { get; set; }
        public Guid? EventRegistrationId { get; set; }
        public Guid TimeZoneMapId { get; set; }
        public Guid ModalityVariantId { get; set; }
        public Guid? SubstitutedModalityVariantId { get; set; }

        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
        public EventRegistration EventRegistration { get; set; }
        public ModalityVariant ModalityVariant { get; set; }
        public ModalityVariant SubstitutedModalityVariant { get; set; }
        public TimeZoneMap TimeZoneMap { get; set; }
        public User User { get; set; }
        public ICollection<CertificateRequest> CertificateRequests { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserQuestionnaire> UserQuestionnaires { get; set; }
    }
}
