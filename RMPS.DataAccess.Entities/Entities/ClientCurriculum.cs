using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ClientCurriculum
    {
        public ClientCurriculum()
        {
            ClientCurriculumPlans = new HashSet<ClientCurriculumPlan>();
            UserCurriculums = new HashSet<UserCurriculum>();
            UserRoleCompliances = new HashSet<UserRoleCompliance>();
        }

        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public int? DurationYears { get; set; }
        public bool ComplianceOptional { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public string AudienceExpression { get; set; }
        public int? Weight { get; set; }
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid CoreCurriculumId { get; set; }

        public Client Client { get; set; }
        public CoreCurriculum CoreCurriculum { get; set; }
        public ICollection<ClientCurriculumPlan> ClientCurriculumPlans { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserRoleCompliance> UserRoleCompliances { get; set; }
    }
}
