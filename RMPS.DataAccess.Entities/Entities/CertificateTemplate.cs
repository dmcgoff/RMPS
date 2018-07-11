using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CertificateTemplate
    {
        public CertificateTemplate()
        {
            CertificateRequests = new HashSet<CertificateRequest>();
        }

        public Guid Id { get; set; }
        public Guid CertificationId { get; set; }
        public Guid CertificateTemplateTypeId { get; set; }
        public Guid FileId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public CertificateTemplateType CertificateTemplateType { get; set; }
        public Certification Certification { get; set; }
        public File File { get; set; }
        public ICollection<CertificateRequest> CertificateRequests { get; set; }
    }
}
