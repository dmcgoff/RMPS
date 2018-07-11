using System;

namespace RMPS.DataAccess.Entities
{
    public partial class RiskAlertNotification
    {
        public Guid KeyGuid { get; set; }
        public int? SelectedResponse { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid UserId { get; set; }
        public Guid ChangedById { get; set; }
        public Guid ClientCurriculumPlanId { get; set; }
        public Guid Id { get; set; }
        public Guid RiskAlertId { get; set; }

        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
        public ModalityVariantsRiskAlert RiskAlert { get; set; }
        public User User { get; set; }
    }
}
