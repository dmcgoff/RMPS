using System;

namespace RMPS.DataAccess.Entities
{
    public partial class EventSessionCertification
    {
        public Guid Id { get; set; }
        public Guid EventSessionId { get; set; }
        public Guid CertificationId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public Certification Certification { get; set; }
        public EventSession EventSession { get; set; }
    }
}
