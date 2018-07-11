using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ClientCurriculumPlanPrerequisite
    {
        public Guid Id { get; set; }
        public Guid ClientCurriculumPlanId { get; set; }
        public Guid ClientCurriculumPlanPrerequisiteId { get; set; }

        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
        public ClientCurriculumPlan ClientCurriculumPlanPrerequisiteNavigation { get; set; }
    }
}
