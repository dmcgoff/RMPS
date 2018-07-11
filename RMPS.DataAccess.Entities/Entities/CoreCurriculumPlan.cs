using System;

namespace RMPS.DataAccess.Entities
{
    public partial class CoreCurriculumPlan
    {
        public bool IsPrerequisite { get; set; }
        public DateTime? StartDate { get; set; }
        public int? DurationMonths { get; set; }
        public int? PreRegistrationMonths { get; set; }
        public int? ClosedMonths { get; set; }
        public int? GracePeriodMonths { get; set; }
        public int? SequenceNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid CoreCurriculumId { get; set; }
        public Guid ModalityId { get; set; }

        public CoreCurriculum CoreCurriculum { get; set; }
        public Modality Modality { get; set; }
    }
}
