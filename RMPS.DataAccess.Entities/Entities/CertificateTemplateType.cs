using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CertificateTemplateType
    {
        public CertificateTemplateType()
        {
            CertificateTemplates = new HashSet<CertificateTemplate>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<CertificateTemplate> CertificateTemplates { get; set; }
    }
}
