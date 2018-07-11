using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantCertification
    {
        public Guid Id { get; set; }
        public Guid ModalityVariantId { get; set; }
        public Guid CertificationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public Certification Certification { get; set; }
        public ModalityVariant ModalityVariant { get; set; }
    }
}
