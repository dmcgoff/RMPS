using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Certification
    {
        public Certification()
        {
            CertificateRequests = new HashSet<CertificateRequest>();
            CertificateTemplates = new HashSet<CertificateTemplate>();
            EventRegistrations = new HashSet<EventRegistration>();
            EventSessionCertifications = new HashSet<EventSessionCertification>();
            ModalityVariantCertifications = new HashSet<ModalityVariantCertification>();
        }

        public Guid Id { get; set; }
        public Guid CertificationProviderId { get; set; }
        public Guid CertificationTypeId { get; set; }
        public Guid CertificationFormatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsIssuable { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public CertificationFormat CertificationFormat { get; set; }
        public CertificationProvider CertificationProvider { get; set; }
        public CertificationType CertificationType { get; set; }
        public ICollection<CertificateRequest> CertificateRequests { get; set; }
        public ICollection<CertificateTemplate> CertificateTemplates { get; set; }
        public ICollection<EventRegistration> EventRegistrations { get; set; }
        public ICollection<EventSessionCertification> EventSessionCertifications { get; set; }
        public ICollection<ModalityVariantCertification> ModalityVariantCertifications { get; set; }
    }
}
