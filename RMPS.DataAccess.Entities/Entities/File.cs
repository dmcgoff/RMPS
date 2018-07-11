using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class File
    {
        public File()
        {
            Brands = new HashSet<Brand>();
            CertificateTemplates = new HashSet<CertificateTemplate>();
            TakeAways = new HashSet<TakeAway>();
            Tools = new HashSet<Tool>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Type { get; set; }
        public byte[] Bytes { get; set; }
        public byte[] Hash { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<Brand> Brands { get; set; }
        public ICollection<CertificateTemplate> CertificateTemplates { get; set; }
        public ICollection<TakeAway> TakeAways { get; set; }
        public ICollection<Tool> Tools { get; set; }
    }
}
