using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class EventRegistration
    {
        public EventRegistration()
        {
            UserCurriculums = new HashSet<UserCurriculum>();
            UserModalityLogs = new HashSet<UserModalityLog>();
        }

        public DateTime DateRegistered { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid UserId { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? ClientCurriculumPlanId { get; set; }
        public Guid Id { get; set; }
        public Guid EventSessionId { get; set; }
        public Guid? CertificationId { get; set; }

        public Certification Certification { get; set; }
        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
        public EventSession EventSession { get; set; }
        public User User { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserModalityLog> UserModalityLogs { get; set; }
    }
}
