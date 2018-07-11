using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            CertificateRequests = new HashSet<CertificateRequest>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<CertificateRequest> CertificateRequests { get; set; }
    }
}
