using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMPS.DataAccess.Entities
{
    [Table("CourseCatalogView")]
    public partial class CourseCatalogView
    {
        public CourseCatalogView()
        {
        }

        public Guid Id { get; set; }

        public Guid ModalityId { get; set; }

        public string ModalityType { get; set; }

        public string CourseId { get; set; }

        public string CourseName { get; set; }

        public Guid VariantId { get; set; }

        public string Description { get; set; }
        
        public DateTime? ReviewDate { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public double Credits { get; set; }

        public string CMECert { get; set; }
        public string CEUCert { get; set; }
        public string RiskSpecific { get; set; }
        public string Setting { get; set; }
        public string MedicalRole { get; set; }
        public string Specialty { get; set; }
        public string State { get; set; }

    }
}
