using System;

namespace RMPS.DataAccess.Entities
{
    public partial class CertificateRequest
    {
        public Guid Id { get; set; }
        public Guid CertificationId { get; set; }
        public Guid? CertificateTemplateId { get; set; }
        public Guid UserModalityLogId { get; set; }
        public Guid ClientId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid CertificateRequestGroupId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? FulfillmentDate { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public decimal? CourseCredits { get; set; }
        public string CourseLocation { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public decimal Price { get; set; }

        public CertificateTemplate CertificateTemplate { get; set; }
        public Certification Certification { get; set; }
        public Client Client { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public UserModalityLog UserModalityLog { get; set; }
    }
}
