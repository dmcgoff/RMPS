using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ClientCurriculumPlanCertificationTypePrice
    {
        public Guid Id { get; set; }
        public Guid ClientCurriculumPlanId { get; set; }
        public Guid CertificationTypeId { get; set; }
        public Guid BillToTypeId { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public BillToType BillToType { get; set; }
        public CertificationType CertificationType { get; set; }
        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
    }
}
